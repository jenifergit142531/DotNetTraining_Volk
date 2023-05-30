using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCApp.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }
        // GET: Home
       // [NonAction]
       /* public ViewResult Index()
        {
            List<string> movies = new List<string>();
            movies.Add("Avatar");
            movies.Add("mario");
            movies.Add("Guardians of galaxy");
            movies.Add("Quantum");

            // ViewData["mymovie"] = movies;
            //ViewBag.mymovie = movies;
            TempData["mymovie"] = movies;
            return View();
        }
       */
        [ActionName("hi")]
        public string Welcome()
        {
            return " Welcome user";
        }
        [ActionName("hello")]
        public string Greetings(string name)
        {
            return $"Hello {name} , Thanks for checking on our web page";
        }

        /* public RedirectResult Index()
         {
             return Redirect("https://www.wikipedia.org/");
         }*/

      /* public RedirectToRouteResult Index()
        {
            return RedirectToRoute(new { controller = "Book", action = "Index" });
        }
      */
        [HttpGet]
        public FileResult Download()
        {
            byte[] filebytes = System.IO.File.ReadAllBytes("C:\\Users\\JeniferY\\May_Vd\\Aspclass7\\notes.txt");
            string filename = "Mynotes.txt";
            return File(filebytes, System.Net.Mime.MediaTypeNames.Application.Octet, filename);
        }

        


    }
}