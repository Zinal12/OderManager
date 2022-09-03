using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OderManager.Models;

namespace OderManager.Controllers
{
    public class HomeController : Controller
    {
        // methodes:---------------

        // Get : Home
        public ActionResult Index()
        {
            // viewBag to use:---------------------
            ViewBag.MyCustomProperty = "Zinal Mulani";
            ViewBag.MyList = new List<string>() { "john", "smit", "kenil", "piyush" };



            List<Employee> empList = new List<Employee>()
        {
            new Employee() { email = "a@gmail.com", Id = 1,Name = "zinal"},
             new Employee() { email = "b@gmail.com", Id = 2,Name = "piyush"},
              new Employee() { email = "c@gmail.com", Id = 3,Name = "Dhaduk"}
        };
            ViewBag.myemplist = empList;
            return View();

        }

        public ActionResult Demo()
        {
            // its call viewdata is - dicstionery----------
            ViewData["MyKey"] = "this is value for my Key";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}