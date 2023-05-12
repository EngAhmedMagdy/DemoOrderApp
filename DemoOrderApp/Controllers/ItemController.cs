using Bussiness.Abstraction;
using Bussiness.Implementation;
using Domain.Entites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoOrderApp.Controllers
{
    public class ItemController : Controller
    {
        private IItemService itemService;
        //private ICartItemService itemService;
        public ItemController(IItemService itemService)
        {
            this.itemService = itemService;
        }
        // GET: ItemController
        public ActionResult Index()
        {
            return View(itemService.GetListOfItems());
        }

        // GET: ItemController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ItemController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ItemController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Item i)
        {
            try
            {
                itemService.Add(i);
                //
            }
            catch
            {
                //
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: ItemController/Edit/5
        public ActionResult Edit(int id)
        {

            return View();
        }

        // POST: ItemController/Edit/5
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


        // POST: ItemController/Delete/5
        public IActionResult Delete(int id)
        {
            try
            {
                itemService.DeleteItemById(id);
            }
            catch
            {
                //
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
