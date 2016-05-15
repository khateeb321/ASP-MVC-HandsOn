using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleMVC.Models;

namespace SimpleMVC.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {

            Employee employee = new Employee()
            {
                EmployeeID = 101,
                Name = "Khateeb",
                Gender = "Male",
                City = "Islamabad"
            };

            return View(employee);
        }

    }
}
