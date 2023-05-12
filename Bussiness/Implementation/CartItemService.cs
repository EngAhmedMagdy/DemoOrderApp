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
    public class CartItemService : ICartItemService
    {
        private ICartItemRepository CartItemRepository;
        public CartItemService(ICartItemRepository CartItemRepository)
        {
            this.CartItemRepository = CartItemRepository;
        }

        public void Add(CartItem i)
        {
            CartItemRepository.Add(i);
        }

        public void Delete(int i)
        {
            CartItemRepository.Delete(i);
        }

        public List<CartItem> GetCartItemsById(int id)
        {
            return CartItemRepository.GetCartItemsById(id);
        }
    }
}
