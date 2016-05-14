using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Passing_List_Controller_to_View.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.Countries = new List<string>()
            {
                "Pakistan",
                "India",
                "China"
            };

            ViewData["Cities"] = new List<string>()
            {
                "Islamabad",
                "New Delhi",
                "Beijing"
            };

            return View();
        }

    }
}
