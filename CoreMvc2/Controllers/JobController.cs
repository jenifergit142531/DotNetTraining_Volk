using CoreMvc2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace CoreMvc2.Controllers
{
    public class JobController : Controller
    {
        private readonly IStringLocalizer<JobController> _localizer;

        public JobController(IStringLocalizer<JobController> localizer)
        {
            _localizer = localizer;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(JobForm jf)
        {
            if(ModelState.IsValid)
            {
                ViewBag.Message = _localizer["Your application is accepted"];

            }
            return View();
        }

    }
}
