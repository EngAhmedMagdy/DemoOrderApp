
using Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Abstraction
{
    public interface IItemRepository
    {
        public List<Item> GetListOfItems();
        public Item GetItemById(int id);
        public void DeleteItemById(int id);
        public void Add(Item order);
        public void Edit(Item order);
    }
}
