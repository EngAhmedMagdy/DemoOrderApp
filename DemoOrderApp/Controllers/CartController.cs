using Bussiness.Abstraction;

using Domain.Entites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DemoOrderApp.Controllers
{
    public class CartController : Controller
    {
        private ICartItemService _cartItemService;
        private ICartService cartService;
        public CartController(ICartItemService cartItemService, ICartService cartService)
        {
            _cartItemService = cartItemService;
            this.cartService = cartService;
        }

        // GET: CartController1
        public ActionResult Index()
        {
            var c = HttpContext.Session.GetString("demo");
            var d = JsonConvert.DeserializeObject<Customer>(c);
            if(d != null)
            {
                var cart = cartService.GetCartById((int)d.Id);
                var list = _cartItemService.GetCartItemsById(cart.Id);
                return View(list);

            }
            return View();
        }
     
        public IActionResult AddItemToCart([FromQuery]int itemId)
        {
            var c = HttpContext.Session.GetString("demo");
            var d = JsonConvert.DeserializeObject<Customer>(c);
            if (d != null)
            {
                var cart = cartService.GetCartById((int)d.Id);
                CartItem cartItem = new()
                {
                    ItemId = itemId,
                    CartId = cart.Id,
                    Count = 1
                };
                _cartItemService.Add(cartItem);
                return RedirectToAction("Index");
            }
            return View();
        }
        // GET: CartController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CartController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CartController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: CartController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CartController1/Edit/5
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

        // GET: CartController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CartController1/Delete/5
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
    }
}
