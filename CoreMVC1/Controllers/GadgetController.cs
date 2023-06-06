using CoreMVC1.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreMVC1.Controllers
{
    public class GadgetController : Controller
    {
        [Route("show")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("welcome")]
        public string Welcome()
        {
            return "Welcome to my shop";
        }

        [Route("gad")]
        public IActionResult GetGadgets()
        {
            List<Gadget> gadgets = new List<Gadget>()
            {
                new Gadget()
                {
                    GadgetId=1,
                    GadgetName="mouse",
                    Price=1200,
                    Quantity=5
            
                },
                new Gadget()
                {
                    GadgetId=2,
                    GadgetName="SSD",
                    Price=3500,
                    Quantity=10

                },
                new Gadget()
                {
                    GadgetId=3,
                    GadgetName="XBOX Console",
                    Price=3000,
                    Quantity=15

                },
            };



            return View(gadgets);
        }
    }
}
