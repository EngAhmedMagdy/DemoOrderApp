using Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstraction
{
    public interface ICartService
    {
        public Cart? GetCartById(int id);
        //public Cart? GetCurrentCart();
        public void Add(Cart c);
    }
}
