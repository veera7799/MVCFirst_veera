using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCFirstProject.Models;

namespace MVCFirstProject.Controllers
{
    public class EmployeeController : Controller
    {
        // GET:Employee
        public ActionResult EmployeeInfo()
            {
            Employee employee = new Employee()
            {
                EmployeeId = 1001,
                EmployeeName = "Veera Kasani",
                EmployeeLocation = "Banglore"
            };


            return View(employee);

            }
        }
    }
