using Microsoft.AspNetCore.Mvc;

namespace CoreMvc2.Controllers
{
    public class SessionController : Controller
    {
        const string sName = "_Name";
        const string sCity = "_City";

        public IActionResult Index()
        {
            HttpContext.Session.SetString(sName, "Jeni");
            HttpContext.Session.SetString(sCity, "Chennai");
            return View();
        }

        public IActionResult Show()
        {
            ViewBag.Name = HttpContext.Session.GetString(sName);
            ViewBag.City = HttpContext.Session.GetString(sCity);
            TempData["sessionId"] = HttpContext.Session.Id;
            ViewData["Message"] = "Session management in asp.net core web api";
            return View();
        }
    }
}
