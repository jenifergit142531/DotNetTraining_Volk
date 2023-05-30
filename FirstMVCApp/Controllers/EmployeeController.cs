using FirstMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCApp.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            Employee[] emp = new Employee[]
            {
                new Employee
                {
                    EmployeeId=101,
                    EmployeeName="Aron",
                    Role="Developer",
                    Location="Reston"
                },
                new Employee
                {
                    EmployeeId=102,
                    EmployeeName="Amy",
                    Role="HR",
                    Location="Florida"
                },
                new Employee
                {
                    EmployeeId=103,
                    EmployeeName="Steve",
                    Role="Manager",
                    Location="Tampa"
                },
                new Employee
                {
                    EmployeeId=104,
                    EmployeeName="Jacob",
                    Role="Finance",
                    Location="India"
                },
                new Employee
                {
                    EmployeeId=105,
                    EmployeeName="Kate",
                    Role="SF Developer",
                    Location="UK"
                }

            };



            return View(emp);
        }
    }
}