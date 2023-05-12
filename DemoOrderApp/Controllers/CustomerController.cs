using Bussiness.Abstraction;
using Bussiness.Implementation;
using Domain.Entites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;
using Newtonsoft.Json;

namespace DemoOrderApp.Controllers
{
    public class CustomerController : Controller
    {
        private ICustomerService customerService;
        private ICartService cartService;
        private ICartItemService _cartItemService;
        public CustomerController(ICustomerService customerService, ICartService cartService, ICartItemService _cartItemService)
        {
            this.customerService = customerService;
            this.cartService = cartService; 
            this._cartItemService = _cartItemService; 
        }
        // GET: CustomerController
        public ActionResult Index()
        {

            return View(customerService.GetListOfCustomer());
        }

        public ActionResult UserCart()
        {
            var c = HttpContext.Session.GetString("demo");
            var d = JsonConvert.DeserializeObject<Customer>(c);
            var cart = cartService.GetCartById(d.Id);
            var items = _cartItemService.GetCartItemsById(cart.Id);
            return View(items);
        }


        // GET: CustomerController/Details/5
        public ActionResult Details(int id)
        {
            var c = HttpContext.Session.GetString("demo");
            var d=JsonConvert.DeserializeObject<Customer>(c);
            return View(d);
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer c)
        {
            try
            {
                customerService.Add(c);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Customer c)
        {
            var user = customerService.GetCustomerByName(c.Name);
            if (user != null)
            {
                HttpContext.Session.SetString("demo", JsonConvert.SerializeObject(user));
                return RedirectToAction("Details");
            }
            return View();
        }
    }
}
