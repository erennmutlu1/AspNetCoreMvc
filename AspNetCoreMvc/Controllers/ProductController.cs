using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreMvc.Models;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Newtonsoft.Json;

namespace AspNetCoreMvc.Controllers
{
    public class ProductController : Controller
    {


        public IActionResult Index()
        {


            var products = new List<Product>
            {
                new Product{Id=1,ProductName = "A Product",Quantity = 17},
                new Product{Id=2,ProductName = "B Product",Quantity = 19},
                new Product{Id=3,ProductName = "C Product",Quantity = 8}

            };


            #region Sending Model-Based data


            //return View(products);



            #endregion

            #region ViewBag
              ViewBag.products = products;                      //The data which is transfering to view will be transfered with a dynamic object.

            #endregion

            #region ViewData

            ViewData["products"] = products;
            #endregion

            #region TempData

          //  string data= JsonSerializer.Serialize(products);
            TempData["products"] = products; // The main differences between ViewData and TempData is If we want to transfer a data to another action method we use TempData.

            #endregion

            //return RedirectToAction("Index1", "Product");
            return View();
        }


        public IActionResult GetProducts()
        {
            return View();
        }

        //public IActionResult Index1()
        //{

        //    var v1=ViewBag.products;
        //    var v2 = ViewData["products"];
        //    var v3 = TempData["products"];
        //    return View();
        //}
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        #region NonActionMethod
        //public IActionResult Index()
        //{


        //    X();
        //    return View();

        //}

        //[NonAction]
        //public void X()
        //{


        //}


        #endregion

        #region IActionResult
        //public IActionResult GetProducts() // We should give a name to Razor page in Product folder of Views  up to IActionResult name like GetProducts.cshtml
        //{

        //    Product product = new Product();

        //    // Created a Data

        //    //ViewResult result =View("GetProducts");   We can create another razor pages and their salt names are should be written in View("requiredRazorPage") method.
        //    //return result;     


        //    return View();
        //}

        #endregion

        #region ViewResult
        //public ViewResult GetProducts()   

        //{
        //    ViewResult result = View();

        //    return result;
        //}
        #endregion

        #region PartialViewResult

        //public PartialViewResult GetProducts()      //Using in client-based ajax requests
        //{
        //    PartialViewResult result = PartialView();

        //    return result;
        //}

        #endregion

        #region JsonResult

        //public JsonResult GetProducts()            //Data is proccesing as a Json file.
        //{
        //    JsonResult result = Json(new Product
        //    {
        //        Id=5,
        //        ProductName = "Slippers",
        //        Quantity = 17
        //    });

        //    return result;
        //}

        #endregion

        #region EmptyResult

        //public EmptyResult GetProducts()
        //{

        //    return new EmptyResult();
        //}

        #endregion

        #region ContentResult

        //public ContentResult GetProducts()
        //{
        //    ContentResult result = Content("Time is ticking!!!!!!!!");

        //    return result;
        //}

        #endregion

        #region ActionResult

        //public ActionResult GetProducts()
        //{
        //    if (true)
        //    {
        //        return Json(new object());
        //    }
        //    else if (true)
        //    {
        //        return Content("BOOOOO! You have been  detected by Erry");

        //    }

        //    return View();

        //}

        #endregion
    }
}
