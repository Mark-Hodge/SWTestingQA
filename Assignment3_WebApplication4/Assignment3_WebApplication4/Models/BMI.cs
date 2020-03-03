﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment3_WebApplication4.Models
{
    public class BMI
    {
        public int heightFeet { get; set; }
        public int heightInches { get; set; }
        public int weightPounds { get; set; }

        private double bmiValue;

        public double CalculateBMI()
        {
            double result;
            int totalInches = ((heightFeet * 12) + heightInches);
            double heightMeters = (totalInches * 0.025);
            double heightCM = Math.Pow(heightMeters, 2);
            double weightKG = (0.45 * weightPounds);

            result = (weightKG / heightCM);
            result = Math.Round(result, 1);
            bmiValue = result;
            return result;
        }

        public string DetermineCategory()
        {
            if (bmiValue <= 18.5)
                return "Underweight";
            else if (bmiValue > 18.5 && bmiValue <= 24.9)
                return "NormalWeight";
            else if (bmiValue > 24.9 && bmiValue <= 29.9)
                return "Overweight";
            else if (bmiValue > 29.9)
                return "Obese";
            else
                return "NotCategorized";
        }
    }
}