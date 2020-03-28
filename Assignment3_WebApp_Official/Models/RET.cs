using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3_WebApp_Official.Models
{
    public class RET
    {
        public int age { get; set; }
        public double salary { get; set; }
        public double saved { get; set; }
        public double goal { get; set; }

        private double empContribution = 0.35;
        private double mortality = 100;

        private double retirementAge;
        private bool willMeetGoal;

        public Tuple<double, bool> RETTest()
        {
            CalculateRET();
            DetermineGoalMet();
            Tuple<double, bool> results = Tuple.Create(retirementAge, willMeetGoal);
            return results;
        }

        public double CalculateRET()
        {
            if (age == 0 || salary == 0 || goal == 0)
            {
                return retirementAge;
            }

            double personalSavings = (salary * (saved / 100));
            double empContributeAmount = (personalSavings * empContribution);

            personalSavings = (personalSavings + empContributeAmount);
            retirementAge = ((Math.Ceiling(goal / personalSavings)) + age);

            return retirementAge;
        }

        public string DetermineGoalMet()
        {
            if (retirementAge >= mortality)
            {
                willMeetGoal = false;
                return "It is unlikely your goal will be met";
            }

            else if (retirementAge < mortality && retirementAge > 0)
            {
                willMeetGoal = true;
                return "It is likely your goal will be met";
            }

            else
            {
                willMeetGoal = false;
                return "It is undetermined your goal will be met";
            }
        }
    }
}
