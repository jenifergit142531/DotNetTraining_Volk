using MyCreateProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyCreateProject.Controllers
{
    [Route("product")]
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        [Route("demo1")]
        public ContentResult Demo1()
        {
            return Content("Hello", "text/plain");
        }

        [Route("demo2/{name}")]
        public ContentResult Demo2(string name)
        {
            return Content("Hello" + name, "text/plain");
        }

        [Route("demo3")]
        public JsonResult Demo3()
        {
            var products = new List<Product>()
            {
                new Product()
                {
                   Id=101,
                   Name="Mobile",
                   Price=45000
                },
                new Product()
                {
                   Id=102,
                   Name="Mac",
                   Price=125000
                },
                new Product()
                {
                   Id=103,
                   Name="Mouse",
                   Price=1500
                },
                new Product()
                {
                   Id=104,
                   Name="Laptop",
                   Price=78000
                }

            };
            return Json(products);
        }

    }
}