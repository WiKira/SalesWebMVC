﻿using Microsoft.AspNetCore.Mvc;

namespace SalesWebMVC.Controllers
{
    public class SalesRecordsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SimpleSeach()
        {
            return View();
        }

        public IActionResult GroupingSearch()
        {
            return View();
        }
    }
}
