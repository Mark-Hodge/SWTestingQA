using Assignment3_WebApp5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment3_WebApp5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Overview";

            return View();
        }

        public ActionResult BMI()
        {
            ViewBag.Message = "Your BMI page";

            return View();
        }

        [HttpPost]
        public ActionResult BMI(BMI bmi)
        {
            double resultBMI = bmi.CalculateBMI();
            string resultCategory = bmi.DetermineCategory();
            string result = ("Your BMI is " + (resultBMI.ToString()) + ", You are " + resultCategory);
            ViewBag.Message = result;

            return View();
        }

        public ActionResult RET()
        {
            ViewBag.Message = "Your Retirement page";

            return View();
        }

        [HttpPost]
        public ActionResult RET(RET ret)
        {
            double resultAge = ret.CalculateRET();
            string resultGoal = ret.DetermineGoalMet();
            string result = ("The age you could retire is " + (resultAge.ToString()) + ", " + resultGoal);
            ViewBag.Message = result;

            return View();
        }
    }
}