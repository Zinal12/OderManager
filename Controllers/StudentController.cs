using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OderManager.Models;

namespace OderManager.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            List<Employee> emp = new List<Employee>()
            {
                new Employee()
                {
                    Id = 1,
                    Name = "ZinalDhaduk",
                    email = "Zinal@gmail.com"


                }
            };
            return View(emp);
        }
    }
}