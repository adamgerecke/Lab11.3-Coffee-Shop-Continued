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

        public void PrepareRegisterPage()
        {
            ViewBag.Message = "Register";
        }

        public void PrepareOrderPage()
        {
            ViewBag.Message = "Order";
        }

        public void PrepareOrderSummary()
        {
            ViewBag.Message = "Order Summary";
        }

        [HttpGet]
        public ActionResult OrderPage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult OrderPickup()
        {
            return View();
        }

        [HttpPost]
        public ActionResult OrderDelivery()
        {
            return View();
        }

        [HttpPost]
        public ActionResult OrderSummary(string ordertype, string drinkselection, string drinksize, string firstName, string lastName, string emailAddress, string telNumber, string password, string state, string cupsPerDay, string handedness, string coffeeStyle, string ordernumber)
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
                coffeeStyle = coffeeStyle,
                drinkselection = drinkselection,
                drinksize = drinksize,
                ordernumber = ordernumber
            };

            if (ordertype == "Pickup")
            {
                PrepareOrderSummary();
                return View("OrderPickup");
            }
            else if(ordertype == "Delivery")
            {
                PrepareOrderSummary();
                return View("OrderDelivery");

            }
            PrepareOrderSummary();
            return View(user);
        }

        [HttpGet]
        public ActionResult Register()
        {
            PrepareRegisterPage();
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

            if(firstName == "" && lastName =="")
            {
                PrepareRegisterPage();
                ViewBag.FirstNameErrorMessage = "Sorry, First Name is a required field.<br />";
                ViewBag.LastNameErrorMessage = "Sorry, Last Name is a required field.<br />";
                return View("Register");
            }
            else if (firstName == "")
            {
                PrepareRegisterPage();
                ViewBag.FirstNameErrorMessage = "Sorry, First Name is a required field.<br />";
                return View("Register");
            }
            else if (lastName == "")
            {
                PrepareRegisterPage();
                ViewBag.LastNameErrorMessage = "Sorry, Last Name is a required field.<br />";
                return View("Register");
            }

            return View(user);
        }
    }
}