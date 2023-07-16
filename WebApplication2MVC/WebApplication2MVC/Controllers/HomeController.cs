using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2MVC.Models;

namespace WebApplication2MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //List<string> names = new List<string>
            //{
            //    "Joe",
            //    "Adam",
            //    "Bob"
            //};
            // other example - int number = 5;

            User user = new User();
            user.Id = 1;
            user.FirstName = "Joe";
            user.LastName = "Lombardo";
            user.Age = 27;

            return View(user);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            //throw new Exception("Invalid Page");

            return View();
        }

        public ActionResult Contact(int id=0)
        {
            ViewBag.Message = id;

            return View();
        }
    }
}

//// Example of logging through the controller.
//string text = "Hello";
//System.IO.File.WriteAllText(@"C:\Users\jlomb\Documents\log\ExampleMVClog.txt", text);
//Random rnd = new Random(10);
//var num = rnd.Next();

//ViewBag.RandomNumber = num;
//if (num > 20000)
//{
//    return View("About"); // How to return a different view.
//}
/*return Content("hello");*/ // Example of a different way to return something.
//return View();
//return RedirectToAction("Contact"); 