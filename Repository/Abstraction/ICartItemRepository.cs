using Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Abstraction
{
    public interface ICartItemRepository
    {
        public List<CartItem> GetCartItemsById(int id);
        public void Add(CartItem i);
        public void Delete(int i);
        public void Edit(CartItem i);
    }
}
