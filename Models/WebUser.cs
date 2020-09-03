using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab_11._3_Coffee_Shop_Registration_Continued.Models
{
    public class WebUser
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string emailAddress { get; set; }
        public string telNumber { get; set; }
        public string password { get; set; }
        public string state { get; set; }
        public string cupsPerDay { get; set; }
        public string handedness { get; set; }
        public string coffeeStyle { get; set; }

    }
}