using DemoOrderApp.Models;
using static NuGet.Packaging.PackagingConstants;

namespace DemoOrderApp.Repository
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
