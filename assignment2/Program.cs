using System;

namespace SWTestingQA_assignment2
{
    class BodyMassIndex
    {
        double bmi, pounds;
        int feet, inches;

        public BodyMassIndex()
        {
            bmi = 0.00; pounds = 0.00;
            feet = 0; inches = 0;
        }


        public BodyMassIndex(int usrFeet, int usrInches, double usrPounds)
        {
            feet = usrFeet; inches = usrInches; pounds = usrPounds;
        }

        public void CalculateBodyMassIndex()
        {
            double weightKG = (pounds * 0.45);
            int totalInches = ((feet * 12) + inches);
            double heightM = (totalInches * 0.025);
            double heightCM = (heightM * heightM);

            bmi = (weightKG / heightCM);
        }

        public void DisplayBMIAndCategory()
        {
            Console.WriteLine("Your Body Mass Index is: {0:0.##}", bmi);

            if (bmi <= 18.5)
                Console.WriteLine("Your BMI Category is: Underweight.\n");

            if (bmi > 18.5 && bmi <= 24.9)
                Console.WriteLine("Your BMI Categegory is: Normal Weight\n");

            if (bmi > 24.9 && bmi <= 29.9)
                Console.WriteLine("Your BMI Categegory is: Overweight\n");

            if (bmi >= 30)
                Console.WriteLine("Your BMI Categegory is: Obese\n");
        }
    }

    class RetirementAge
    {
        int currentAge, deathAge;
        double salary, percentSaved, employerMatch, savingsGoal, retirementAge;
        bool goalMet;

        public RetirementAge(int usrAge, double usrSalary, double usrPercentSaved, double usrSavingsGoal)
        {
            currentAge = usrAge; retirementAge = 0.00; deathAge = 100;
            salary = usrSalary; percentSaved = usrPercentSaved; employerMatch = 0.35; savingsGoal = usrSavingsGoal;
            goalMet = false;
        }

        public void CalculateRetirementGoal()
        {
            double currentPersonalSavings = (salary * percentSaved);
            double employerContribution = (currentPersonalSavings + (currentPersonalSavings * 0.35));
            double totalCurrentSavings = (currentPersonalSavings + employerContribution);
          
            retirementAge = Math.Ceiling(savingsGoal / totalCurrentSavings);
        }

        public void DisplayRetirementInfo()
        {
            Console.WriteLine("The age at which you will meet your goal is {0:0.##}", retirementAge);

            if (retirementAge >= 100)
                Console.WriteLine("It is unrealistic that you will meet your goal (Death at 100yrs)\n");

            if (retirementAge < 100)
                Console.WriteLine("It is likely that you will meet your goal\n");
        }
    }

    class Program
    {
        // Gather input for Body Mass Index.
        public static void UserSelectsBMI()
        {
            bool toMainMenu = false;

            // Determine if the user if they wish to continue or return to the Main Menu.
            Console.WriteLine("\nYou have selected to calculate your body mass index.\r");
            Console.Write("Enter 'Q' to return to the Main Menu. Enter any other key to continue. ");
            string proceed = Console.ReadLine();

            if (proceed.Contains("Q"))
                toMainMenu = true;
            
            // Continue to prompt user to enter data.
            while (!toMainMenu)
            {
                Console.WriteLine("\nEnter the following information: ");

                Console.Write("\tYour height in feet (enter only whole feet)? ");
                string usrFeet = Console.ReadLine();

                Console.Write("\tYour height in inches (enter only inches between 1 and 12)? ");
                string usrInches = Console.ReadLine();

                Console.Write("\tYour weight in pounds? ");
                string usrPounds = Console.ReadLine();

                bool result = ValidateBMIInput(usrFeet, usrInches, usrPounds);
                if (result == true)
                    toMainMenu = true;
            }
        }

        // Gather input for Retirement Age.
        public static void UserSelectsRetirement()
        {
            bool toMainMenu = false;

            // Determine if the user if they wish to continue or return to the Main Menu.
            Console.WriteLine("\nYou have selected to calculate your retirement age.\r");
            Console.Write("Enter 'Q' to return to the Main Menu. Enter any other key to continue. ");
            string proceed = Console.ReadLine();

            if (proceed.Contains("Q"))
                toMainMenu = true;

            while (!toMainMenu)
            {
                Console.WriteLine("\nEnter the following information: ");

                Console.Write("\tYour current age (integer): ");
                string usrCurrentAge = Console.ReadLine();

                Console.Write("\tYour annual salary: ");
                string usrSalary = Console.ReadLine();

                Console.Write("\tYour percentage of salary saved: ");
                string usrPercentSAved = Console.ReadLine();

                Console.Write("\tYour savings goal: ");
                string usrSavingsGoal = Console.ReadLine();

                bool result = ValidateRetirementInput(usrCurrentAge, usrSalary, usrPercentSAved, usrSavingsGoal);
                if (result == true)
                    toMainMenu = true;
            }
        }
                  
        // Validate input for Body Mass Index.
        public static bool ValidateBMIInput(string usrFeet, string usrInches, string usrPounds)
        {
            try
            {
                // Convert user input to numeric data types.
                int feet = int.Parse(usrFeet);
                int inches = int.Parse(usrInches);
                int pounds = int.Parse(usrPounds);

                // Check if input is within the allowable bounds.
                if (feet < 0)
                    throw new System.ArgumentException();

                if (inches < 0 || inches > 12)
                    throw new System.ArgumentException();

                if (pounds < 0.00)
                    throw new System.ArgumentException();

                BodyMassIndex bodyMassIndex = new BodyMassIndex(feet, inches, pounds);
                bodyMassIndex.CalculateBodyMassIndex();
                bodyMassIndex.DisplayBMIAndCategory();
                return true;
            }

            catch (Exception e)
            {
                Console.WriteLine("\nAn exception occured while validating your input.\n -> Details: " + e.Message);
            }

            return false;
        }

        // Validate input for Retirement Age.
        public static bool ValidateRetirementInput(string usrCurrentAge, string usrSalary, string usrPercentSaved, string usrSavingsGoal)
        {
            try
            {
                // Convert user input to numeric data types.
                int currentAge = int.Parse(usrCurrentAge);
                double salary = double.Parse(usrSalary);
                double percentSaved = (double.Parse(usrPercentSaved) / 100);
                double savingsGoal = double.Parse(usrSavingsGoal);

                // Check if input is within the allowable bounds.
                if (currentAge <= 0 || currentAge >= 100)
                    throw new System.ArgumentException();

                if (salary <= 0.00)
                    throw new System.ArgumentException();

                if (percentSaved <= 0.00 || percentSaved >= 100.00)
                    throw new System.ArgumentException();

                if (savingsGoal <= 0.00)
                    throw new System.ArgumentException();

                RetirementAge retirementAge = new RetirementAge(currentAge, salary, percentSaved, savingsGoal);
                retirementAge.CalculateRetirementGoal();
                retirementAge.DisplayRetirementInfo();
                return true;
            }

            catch (Exception e)
            {
                Console.WriteLine("An exception occured while validating your input.\n -> Details: " + e.Message);
            }

            return false;
        } 

        static void Main(string[] args)
        {
            bool endApp = false;

            // Print information to screen on startup.
            Console.WriteLine("Main Menu: Welcome.\r");
            Console.WriteLine("------------------------------");

            while (!endApp)
            {
                // Print the user's options to the screen.
                Console.WriteLine("\nChoose an option from the following list: ");
                Console.WriteLine("\t1 - Calculate Body Mass Index");
                Console.WriteLine("\t2 - Calculate Retirement Age");
                Console.WriteLine("\tQ - Exit");
                Console.Write("Which option would you like? ");

                // Read in the user's desired option.
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        UserSelectsBMI();
                        break;
                    case "2":
                        UserSelectsRetirement();
                        break;
                    case "Q":
                        endApp = true;
                        break;

                    // Continue loop if default.
                    default:
                        break;
                }
            }
        }
    }
}
