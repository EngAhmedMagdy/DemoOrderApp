using Bussiness.Abstraction;
using Domain.Entites;
using Microsoft.AspNetCore.Mvc;

namespace DemoOrderApp.Controllers
{
    public class OrderController : Controller
    {
        private IOrderService orderService;
        public OrderController(IOrderService orderService)
        {
            this.orderService = orderService;
        }
        [Route("App/Order/Main")]
        [HttpGet]
        public IActionResult Index()
        {
            var list = orderService.GetOrders();
            return View(list);
        }
        [HttpGet]
        [Route("App/Order/Add")]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [Route("App/Order/Add")]
        public IActionResult Add(Order order)
        {
            orderService.AddPriceToTotal(order);
            return RedirectToAction("Index");
        }
        [HttpGet]
        [Route("App/Order/Edit/{id}")]
        public IActionResult Edit(int id)
        {
            return View(orderService.GetOrder(id));
        }
        [HttpPost]
        [Route("App/Order/Edit/{id}")]
        public IActionResult Edit(Order order)
        {
            orderService.AddPriceToTotal(order);
            return RedirectToAction("Index");
        }
    }
}
