using Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstraction
{
    public interface IOrderService
    {
        public List<Order> GetListOfOrders(int id);
        public Order GetOrderById(int id);
        public void DeleteOrderById(int id);
        public void Add(List<CartItem> items, int customerid);
        public Order Edit(Order order);
    }
}
