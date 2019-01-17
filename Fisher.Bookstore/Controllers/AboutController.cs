using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{

    public class AboutController: Controller
    {
        public IActionResult Index()
        {
            return Content("Bout that index");
        }

        public IActionResult History()
        {
            return Content("Bout that History");
        }

        public IActionResult Location()
        {
            return Content("Bout that location");
        }
    }

}