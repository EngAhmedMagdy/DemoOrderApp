﻿using Microsoft.AspNetCore.Mvc;

namespace DemoOrderApp.Controllers
{
    public class ItemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
