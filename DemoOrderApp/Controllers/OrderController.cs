using Bussiness.Abstraction;
using Bussiness.Implementation;
using Domain.Entites;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

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
            var c = HttpContext.Session.GetString("User");
            var d = JsonConvert.DeserializeObject<Customer>(c);
            var list = orderService.GetListOfOrders(d.Id);
            return View(list);
        }
        
        [HttpPost]
        [Route("App/Order/Add")]
        public IActionResult Add(List<CartItem> items)
        {
            var c = HttpContext.Session.GetString("User");
            var d = JsonConvert.DeserializeObject<Customer>(c);
            orderService.Add(items,d.Id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        [Route("App/Order/Edit/{id}")]
        public IActionResult Edit(int id)
        {
            return View(orderService.GetOrderById(id));
        }
        [HttpPost]
        [Route("App/Order/Edit/{id}")]
        public IActionResult Edit(Order order)
        {
            orderService.Edit(order);
            return RedirectToAction("Index");
        }
    }
}
