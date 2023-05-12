using Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementation
{
    public class OrderRepository : IOrderRepository
    {
        private Context _dbContex;
        public OrderRepository(Context dbContext)
        {
            _dbContex = dbContext;
        }
        public void Add(Order order)
        {
            _dbContex.Orders.Add(order);
            _dbContex.SaveChanges(); // Saves all changes made in this context to the database 
        }

        public void DeleteOrderById(int id)
        {
            var item = GetOrderById(id);
            _dbContex.Orders.Remove(item);
        }

        public Order Edit(Order order)
        {
            var exist_order = GetOrderById(order.Id);
            if (exist_order != null)
            {
                exist_order.Date = order.Date;
            }
            return exist_order;
        }

        public List<Order> GetListOfOrders(int id)
        {
            return _dbContex.Orders.Where(x=>x.CustomerId == id).ToList();
        }

        public Order? GetOrderById(int id)
        {
            return _dbContex.Orders.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
