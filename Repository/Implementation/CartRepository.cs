using Domain.Entites;
using Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementation
{
    public class CartRepository : ICartRepository
    {
        private Context _dbContex;
        public CartRepository(Context dbContext)
        {
            _dbContex = dbContext;
        }
        public void Add(Cart c)
        {
            _dbContex.Carts.Add(c);
            _dbContex.SaveChanges();
        }

        public Cart? GetCartById(int id)
        {
            return _dbContex.Carts.Where(x => x.CustomerId == id).FirstOrDefault();
        }
    }
}
