using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{

    [Route("books")]
    public class BooksController: Controller
    {

        [Route("")]
        [Route("index")]
            
        public IActionResult Index()
        {
            //return Content("Book ");
            return View();
        }


        [Route("new")]
        public IActionResult New()
        {
            //return Content("New Hottness");
            return View();
        }

        [Route("best-sellers")]
        public IActionResult Best()
        {
            //return Content("Fire Books");
            return View();
        }

        
    }

}