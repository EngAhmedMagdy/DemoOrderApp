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
    public class ItemRepository : IItemRepository
    {
        private Context _dbContex;
        public ItemRepository(Context dbContext)
        {
            _dbContex = dbContext;
        }
        public void Add(Item i)
        {
            _dbContex.Items.Add(i);
            _dbContex.SaveChanges(); // Saves all changes made in this context to the database 
        }

        public void DeleteItemById(int id)
        {
            var item = GetItemById(id);
            _dbContex.Items.Remove(item);
            _dbContex.SaveChanges();
        }

        public void Edit(Item i)
        {
            var record = GetItemById(i.Id);
            _dbContex.Items.Update(record);
            _dbContex.SaveChanges();
        }

        public List<Item> GetListOfItems()
        {
            return _dbContex.Items.ToList();
        }

        public Item? GetItemById(int id)
        {
            return _dbContex.Items.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
