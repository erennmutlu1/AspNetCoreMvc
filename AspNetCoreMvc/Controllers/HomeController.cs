using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()              // Action methods provides and makes the operations for the requests in the Contoller classes.
        {
            return View();
        }



        public IActionResult Index1()
        {
            return View();
        }

        public IActionResult Index2()
        {
            return View();
        }
    }
}
