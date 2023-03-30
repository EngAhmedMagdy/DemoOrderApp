using DemoOrderApp.Models;
using static NuGet.Packaging.PackagingConstants;

namespace DemoOrderApp.Repository
{
    public class OrderRepository
    {

        List<Order> _orders;
        public OrderRepository()
        {

            var cusotmer = new Customer(1, "ahmed", "add", "012");
            _orders = new();
            _orders.Add(new Order(1, DateTime.Now.ToString(), cusotmer));
            _orders.Add(new Order(2, DateTime.Now.ToString(), cusotmer));
            _orders.Add(new Order(3, DateTime.Now.ToString(), cusotmer));
            _orders.Add(new Order(4, DateTime.Now.ToString(), cusotmer));
        }
        public List<Order> GetListOfOrders()
        {
            return _orders;
        }
        public Order GetOrderById(int id)
        {
            return _orders.Where(x=>x.Id == id).First();
        }
        public void DeleteOrderById(int id)
        {
            var item = GetOrderById(id);
            _orders.Remove(item);
        }
        public void Add(Order order)
        {
            _orders.Add(order);
        }
        public Order Edit(Order order)
        {
            var exist_order = GetOrderById(order.Id);
            if(exist_order != null)
            {
                exist_order.Date = order.Date;
            }
            return exist_order;
        }
        
    }
}
