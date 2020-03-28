using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assignment3_WebApp_Official.Models;

namespace Assignment3_WebApp_Official.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Application Details";

            return View();
        }

        public IActionResult BMI()
        {
            ViewBag.Message = "Your BMI page";

            return View();
        }

        [HttpPost]
        public IActionResult BMI(BMI bmi)
        {
            double resultBMI = bmi.CalculateBMI();
            string resultCategory = bmi.DetermineCategory();
            string result = ("Your BMI is " + (resultBMI.ToString()) + ", You are " + resultCategory);
            ViewBag.Message = result;

            return View();
        }

        public IActionResult RET()
        {
            ViewBag.Message = "Your Retirement page";

            return View();
        }

        [HttpPost]
        public IActionResult RET(RET ret)
        {
            double resultAge = ret.CalculateRET();
            string resultGoal = ret.DetermineGoalMet();
            string result = ("The age you could retire is " + (resultAge.ToString()) + ", " + resultGoal);
            ViewBag.Message = result;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
