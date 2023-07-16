using NewsLetterAppMVC.Models;
using NewsLetterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsLetterAppMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost] // Anytime your doing a "post" method your supposed to put this tag above it (not necessary but good practice).
        public ActionResult SignUp(string firstName, string lastName, string emailAddress) // MVC knows what to map - model finding.
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                using (NewsletterEntities db = new NewsletterEntities())
                {
                    var signup = new SignUp();
                    signup.FirstName = firstName;
                    signup.LastName = lastName;
                    signup.EmailAddress = emailAddress;

                    db.SignUps.Add(signup);
                    db.SaveChanges();

                }
                return View("Success");
            }
        }
    }
}

// Here is an example of how much code was written just to create what we have above in the using statement "NewsletterEntities db = new NewsletterEntities()":

//string queryString = @"SELECT Id, FirstName, LastName, EmailAddress, SocialSecurityNumber From SignUps";
//List<NewsletterSignUp> signups = new List<NewsletterSignUp>();
//using (SqlConnection connection = new SqlConnection(connectionString))
//{
//    SqlCommand command = new SqlCommand(queryString, connection);
//    connection.Open();
//    SqlDataReader reader = command.ExecuteReader();
//    while(reader.Read())
//    {
//        var signup = new NewsletterSignUp();
//        signup.Id = Convert.ToInt32(reader["Id"]);
//        signup.FirstName = reader["FirstName"].ToString();
//        signup.LastName = reader["LastName"].ToString();
//        signup.EmailAddress = reader["EmailAddress"].ToString();
//        signup.SocialSecurityNumber = reader["SocialSecurityNumber"].ToString();
//        signups.Add(signup);
//    }
//}