using CoreMvc2.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreMvc2.Controllers
{
    public class EmployeeHelperController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            Employee emp = new Employee()
            {
                EmpId = 100,
                Name = "Mira",
                Role = "Trainer"
            };

            ViewData["EmpDetails"] = emp;
            return View();
        }
    }
}
