using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{

    public class AuthorController: Controller
    {
        public IActionResult Index()
        {
            return Content("The Writer ");
        }

        public IActionResult Featured()
        {
            return Content("The Best Writer");
        }
        
    }

}