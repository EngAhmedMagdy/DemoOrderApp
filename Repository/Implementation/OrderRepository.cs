using Domain.Entites;
using Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementation
{
    public class OrderRepository : IOrderRepository
    { 
        List<Order> _orders; //database reference (db context)
        public OrderRepository()
        {
            var cusotmer = new Customer(1, "ahmed", "add", "012");
            _orders = new();
            _orders.Add(new Order(1, DateTime.Now.ToString(), cusotmer));
            _orders.Add(new Order(2, DateTime.Now.ToString(), cusotmer));
            _orders.Add(new Order(3, DateTime.Now.ToString(), cusotmer));
            _orders.Add(new Order(4, DateTime.Now.ToString(), cusotmer));
        }
        public void Add(Order order)
        {
            _orders.Add(order);
        }

        public void DeleteOrderById(int id)
        {
            var item = GetOrderById(id);
            _orders.Remove(item);
        }

        public Order Edit(Order order)
        {
            var exist_order = GetOrderById(order.Id);
            if (exist_order != null)
            {
                exist_order.Date = order.Date;
                exist_order.Name = order.Name;
            }
            return exist_order;
        }

        public List<Order> GetListOfOrders()
        {
            return _orders;
        }

        public Order GetOrderById(int id)
        {
            return _orders.Where(x => x.Id == id).First();
        }
    }
}
