using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab_11._3_Coffee_Shop_Registration_Continued.Models;

namespace Lab_11._3_Coffee_Shop_Registration_Continued.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Saul's Coffee Bar. Serving the Downtown Detroit Area with Coffee - since never! We don't exist!";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "This isn't our real address, or phone number since we are not a real company.";

            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddUser(string firstName, string lastName, string emailAddress, string telNumber, string password, string state, string cupsPerDay, string handedness, string coffeeStyle)
        {
            WebUser user = new WebUser()
            {
                firstName = firstName,
                lastName = lastName,
                emailAddress = emailAddress,
                telNumber = telNumber,
                password = password,
                state = state,
                cupsPerDay = cupsPerDay,
                handedness = handedness,
                coffeeStyle = coffeeStyle

            };
            return View(user);
        }
    }
}