using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{

    public class BooksController: Controller
    {
        public IActionResult Index()
        {
            return Content("Book ");
        }

        public IActionResult New()
        {
            return Content("New Hottness");
        }

        public IActionResult BestSellers()
        {
            return Content("Fire Books");
        }

        
    }

}