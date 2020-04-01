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
            ViewData["Title"] = "About The Application";
            ViewData["Message"] = "Application Instructions";

            return View();
        }

        public IActionResult BMI()
        {
            ViewBag.Title = "Body Mass Index Calculator";
            ViewBag.Message = "Your BMI page";

            return View();
        }

        [HttpPost]
        public IActionResult BMI(BMI bmi)
        {
            ViewBag.Title = "Body Mass Index Calculator";

            try
            {
                if (bmi == null)
                {
                    throw new ArgumentNullException();
                }

                double resultBMI = bmi.CalculateBMI();
                string resultCategory = bmi.DetermineCategory();
                string result = ("Your BMI is " + (resultBMI.ToString()) + ", You are " + resultCategory);
                ViewBag.Message = result;

                return View();
            }
            catch (ArgumentNullException)
            {
                return View();
            }

        }

        public IActionResult RET()
        {
            ViewBag.Title = "Retirement Calculator";
            ViewBag.Message = "Your Retirement page";

            return View();
        }

        [HttpPost]
        public IActionResult RET(RET ret)
        {
            ViewBag.Title = "Retirement Calculator";

            try
            {
                if (ret == null)
                {
                    throw new ArgumentNullException();
                }

                double resultAge = ret.CalculateRET();
                string resultGoal = ret.DetermineGoalMet();
                string result = ("The age you could retire is " + (resultAge.ToString()) + ", " + resultGoal);
                ViewBag.Message = result;

                return View();
            }
            catch (ArgumentNullException)
            {
                return View();
            }

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
