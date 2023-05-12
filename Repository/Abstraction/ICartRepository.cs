using Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Abstraction
{
    public interface ICartRepository
    {
        public Cart? GetCartById(int id);
        public void Add(Cart c);
    }
}
