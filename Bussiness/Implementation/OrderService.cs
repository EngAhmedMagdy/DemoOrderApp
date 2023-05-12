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
    public class OrderService : IOrderService
    {
        private IOrderRepository _orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public void Add(List<CartItem> items,int customerid)
        {
            foreach(var item in items)
            {
                Order order = new Order()
                {
                    CustomerId = customerid,
                    CartItemId = item.Id,
                    Cost = item.Count * item.Item.Price,
                    Date = DateTime.Now.ToString()
                };
                _orderRepository.Add(order);
            }
            
        }

        public void DeleteOrderById(int id)
        {
            throw new NotImplementedException();
        }

        public Order Edit(Order order)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetListOfOrders(int id)
        {
            return _orderRepository.GetListOfOrders(id);
        }

        public Order GetOrderById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
