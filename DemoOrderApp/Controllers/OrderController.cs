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
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [Route("App/Order/Edit/{id}")]
        public IActionResult Edit(int id)
        {
            ;
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
