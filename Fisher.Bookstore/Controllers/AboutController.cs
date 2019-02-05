using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{

    public class AboutController: Controller
    {
        public IActionResult Index()
        {
            //return Content("Bout that index");
            return View();
        }

        public IActionResult History()
        {
            //return Content("Bout that History");
            return View();
        }

        public IActionResult Location()
        {
            //return Content("Bout that location");
            return View();
        }


    }

}