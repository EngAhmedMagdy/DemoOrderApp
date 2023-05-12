using Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementation
{
    public class CartItemRepository : ICartItemRepository
    {
        private Context _dbContex;
        public CartItemRepository(Context dbContext)
        {
            _dbContex = dbContext;
        }

        public void Add(CartItem i)
        {
            _dbContex.CartItems.Add(i);
            _dbContex.SaveChanges();
        }

        public void Delete(int i)
        {
            _dbContex.CartItems.Remove(Find(i));
            _dbContex.SaveChanges();
        }

        public void Edit(CartItem i)
        {
            _dbContex.CartItems.Update(i);
        }

        public CartItem Find(int id)
        {
            return _dbContex.CartItems.Find(id);
        }
        public List<CartItem> GetCartItemsById(int id)
        {
            return _dbContex.CartItems.Where(x => x.CartId == id).Include(x=>x.Item).ToList();
        }
    }
}
