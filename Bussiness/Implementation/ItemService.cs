using Bussiness.Abstraction;
using Domain.Entites;
using Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Implementation
{
    public class ItemService : IItemService
    {
        private IItemRepository _itemRepository;

        public ItemService(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public void Add(Item i)
        {
            _itemRepository.Add(i);
        }

        public void DeleteItemById(int id)
        {
            _itemRepository.DeleteItemById(id);
        }

        public void Edit(Item i)
        {
            _itemRepository.Edit(i);
        }

        public Item GetItemById(int id)
        {
            return _itemRepository.GetItemById(id);
        }

        public List<Item> GetListOfItems()
        {
            return _itemRepository.GetListOfItems();
        }
    }
}
