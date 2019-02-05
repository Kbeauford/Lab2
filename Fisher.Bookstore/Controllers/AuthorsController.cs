using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{

    public class AuthorsController: Controller
    {
        public IActionResult Index()
        {
            //return Content("The Writer ");
            return View();
        }

        public IActionResult Featured()
        {
            //return Content("The Best Writer");
            return View();
        }
        
            

    }

}