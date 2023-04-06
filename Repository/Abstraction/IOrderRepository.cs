
using Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Abstraction
{
    public interface IOrderRepository
    {
        public List<Order> GetListOfOrders();
        public Order GetOrderById(int id);
        public void DeleteOrderById(int id);
        public void Add(Order order);
        public Order Edit(Order order);
    }
}
