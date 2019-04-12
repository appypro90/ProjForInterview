using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjForInterview.Models;

namespace ProjForInterview.Controllers
{
    public class ProductController : Controller
    {
        //This action is for viewbag demonstration.
        public ActionResult Index()
        {
            ViewBag.Message = "This message is from product controller.";
            return View();
        }

        //This action is for model demonsrtation.
        public ActionResult GetProduct()
        {
            List<Product> products = new List<Product>()
            {
                new Product {ProductId = 1, ProductName = "Product name 1"},
                new Product {ProductId = 2, ProductName = "Product name 2"},
                new Product {ProductId = 3, ProductName = "Product name 3"}
            };
            
            return View(products);
        }

        //This action is for partial view. 
        //It can be available only in this controller as it is not in shared folder.
        public ActionResult PartialProduct()
        {
            return View("_ProductPartial");
        }
    }
}