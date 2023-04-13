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
        public int CalculateFee();
        public void AddPriceToTotal(Order order);
        public Order GetOrder(int id);
        public List<Order> GetOrders();
    }
}
