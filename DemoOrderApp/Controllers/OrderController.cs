using DemoOrderApp.Models;
using DemoOrderApp.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DemoOrderApp.Controllers
{
    public class OrderController : Controller
    {
        OrderRepository orderRepository;
        public OrderController()
        {
            orderRepository = new();
        }
        [Route("App/Order/Main")]
        public IActionResult Index()
        {
            
            var _orders = orderRepository.GetListOfOrders();
            return View(_orders);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var order = orderRepository.GetOrderById(id);
            return View(order);
        }
        [HttpPost]
        public IActionResult Edit(Order order)
        {
            orderRepository.Edit(order);
            return RedirectToAction("Index");
        }
    }
}
