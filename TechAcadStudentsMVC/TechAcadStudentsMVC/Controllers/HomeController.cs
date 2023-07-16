using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechAcadStudentsMVC.Models;

namespace TechAcadStudentsMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Page - The Tech Academy";

            return View();
        }

        public ActionResult Instructors()
        {
            List<Instructor> instructors = new List<Instructor>
            {
                new Instructor
                {
                    Id = 1,
                    FirstName = "Rick",
                    Lastname = "Ramen"
                },
                new Instructor
                {
                    Id = 2,
                    FirstName = "Brett",
                    Lastname = "Calendar"
                },
                new Instructor
                {
                    Id = 3,
                    FirstName = "Adam",
                    Lastname = "Smithsonian"
                }
            };

            return View(instructors);
        }

        public ActionResult Instructor(int id)
        {
            ViewBag.Id = id;

            Instructor dayTimeInstructor = new Instructor
            {
                Id = 1,
                FirstName = "Erik",
                Lastname = "Gross"
            };

            return View(dayTimeInstructor);
        }
    }
}