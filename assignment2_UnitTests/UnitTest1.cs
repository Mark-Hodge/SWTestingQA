using Microsoft.VisualStudio.TestTools.UnitTesting;
using SWTestingQA_assignment2;
using System;

namespace assignment2_UnitTests
{
    // Body Mass Index Unit Tests
    [TestClass]
    public class BodyMassIndexTests
    {
        // Test Case A1: BMI Category - Underweight, epsilon = 0.1, [0, 18.5]
        [TestMethod]
        [TestCategory("A1")]
        public void BMICategory_Underweight_ShouldEqualExpected()
        {
            // Arrange
            double P1_bmi = -0.9;
            double P2_bmi = 0.00;
            double P3_bmi = 9.25;
            double P4_bmi = 18.5;
            double P5_bmi = 18.6;

            string P1_expected = "Not Valid";
            string P2ToP4_expected = "Underweight";
            string P5_expected = "Normal Weight";

            BodyMassIndex P1_bodyMassIndex = new BodyMassIndex(P1_bmi);
            BodyMassIndex P2_bodyMassIndex = new BodyMassIndex(P2_bmi);
            BodyMassIndex P3_bodyMassIndex = new BodyMassIndex(P3_bmi);
            BodyMassIndex P4_bodyMassIndex = new BodyMassIndex(P4_bmi);
            BodyMassIndex P5_bodyMassIndex = new BodyMassIndex(P5_bmi);

            // Act
            P1_bodyMassIndex.DisplayBMIAndCategory();
            P2_bodyMassIndex.DisplayBMIAndCategory();
            P3_bodyMassIndex.DisplayBMIAndCategory();
            P4_bodyMassIndex.DisplayBMIAndCategory();
            P5_bodyMassIndex.DisplayBMIAndCategory();

            // Assert
            string P1_actual = P1_bodyMassIndex.getCategory;
            string P2_actual = P2_bodyMassIndex.getCategory;
            string P3_actual = P3_bodyMassIndex.getCategory;
            string P4_actual = P4_bodyMassIndex.getCategory;
            string P5_actual = P5_bodyMassIndex.getCategory;

            Assert.AreEqual(P1_expected, P1_actual, "", "P1 BMI Category Not Correct");
            Assert.AreEqual(P2ToP4_expected, P2_actual, "", "P2 BMI Category Not Correct");
            Assert.AreEqual(P2ToP4_expected, P3_actual, "", "P3 BMI Category Not Correct");
            Assert.AreEqual(P2ToP4_expected, P4_actual, "", "P4 BMI Category Not Correct");
            Assert.AreEqual(P5_expected, P5_actual, "", "P5 BMI Category Not Correct");
        }

        // Test Case A2: BMI Category - Normal Weight, epsilon = 0.1, (18.5, 24.9]
        [TestMethod]
        [TestCategory("A2")]
        public void BMICategory_NormalWeight_ShouldEqualExpected()
        {
            // Arrange
            double P1_bmi = 18.6;
            double P2_bmi = 18.7;
            double P3_bmi = 21;
            double P4_bmi = 24.9;
            double P5_bmi = 25;

            string P1_expected = "Normal Weight";
            string P2ToP4_expected = "Normal Weight";
            string P5_expected = "Overweight";

            BodyMassIndex P1_bodyMassIndex = new BodyMassIndex(P1_bmi);
            BodyMassIndex P2_bodyMassIndex = new BodyMassIndex(P2_bmi);
            BodyMassIndex P3_bodyMassIndex = new BodyMassIndex(P3_bmi);
            BodyMassIndex P4_bodyMassIndex = new BodyMassIndex(P4_bmi);
            BodyMassIndex P5_bodyMassIndex = new BodyMassIndex(P5_bmi);

            // Act
            P1_bodyMassIndex.DisplayBMIAndCategory();
            P2_bodyMassIndex.DisplayBMIAndCategory();
            P3_bodyMassIndex.DisplayBMIAndCategory();
            P4_bodyMassIndex.DisplayBMIAndCategory();
            P5_bodyMassIndex.DisplayBMIAndCategory();

            // Assert
            string P1_actual = P1_bodyMassIndex.getCategory;
            string P2_actual = P2_bodyMassIndex.getCategory;
            string P3_actual = P3_bodyMassIndex.getCategory;
            string P4_actual = P4_bodyMassIndex.getCategory;
            string P5_actual = P5_bodyMassIndex.getCategory;

            Assert.AreEqual(P1_expected, P1_actual, "", "P1 BMI Category Not Correct");
            Assert.AreEqual(P2ToP4_expected, P2_actual, "", "P2 BMI Category Not Correct");
            Assert.AreEqual(P2ToP4_expected, P3_actual, "", "P3 BMI Category Not Correct");
            Assert.AreEqual(P2ToP4_expected, P4_actual, "", "P4 BMI Category Not Correct");
            Assert.AreEqual(P5_expected, P5_actual, "", "P5 BMI Category Not Correct");
        }

        // Test Case A3: BMI Category - Overweight, epsilon = 0.1, [25, 29.9]
        [TestMethod]
        [TestCategory("A3")]
        public void BMICategory_Overweight_ShouldEqualExpected()
        {
            // Arrange
            double P1_bmi = 24.9;
            double P2_bmi = 25;
            double P3_bmi = 27;
            double P4_bmi = 29.9;
            double P5_bmi = 30;

            string P1_expected = "Normal Weight";
            string P2ToP4_expected = "Overweight";
            string P5_expected = "Obese";

            BodyMassIndex P1_bodyMassIndex = new BodyMassIndex(P1_bmi);
            BodyMassIndex P2_bodyMassIndex = new BodyMassIndex(P2_bmi);
            BodyMassIndex P3_bodyMassIndex = new BodyMassIndex(P3_bmi);
            BodyMassIndex P4_bodyMassIndex = new BodyMassIndex(P4_bmi);
            BodyMassIndex P5_bodyMassIndex = new BodyMassIndex(P5_bmi);

            // Act
            P1_bodyMassIndex.DisplayBMIAndCategory();
            P2_bodyMassIndex.DisplayBMIAndCategory();
            P3_bodyMassIndex.DisplayBMIAndCategory();
            P4_bodyMassIndex.DisplayBMIAndCategory();
            P5_bodyMassIndex.DisplayBMIAndCategory();

            // Assert
            string P1_actual = P1_bodyMassIndex.getCategory;
            string P2_actual = P2_bodyMassIndex.getCategory;
            string P3_actual = P3_bodyMassIndex.getCategory;
            string P4_actual = P4_bodyMassIndex.getCategory;
            string P5_actual = P5_bodyMassIndex.getCategory;

            Assert.AreEqual(P1_expected, P1_actual, "", "P1 BMI Category Not Correct");
            Assert.AreEqual(P2ToP4_expected, P2_actual, "", "P2 BMI Category Not Correct");
            Assert.AreEqual(P2ToP4_expected, P3_actual, "", "P3 BMI Category Not Correct");
            Assert.AreEqual(P2ToP4_expected, P4_actual, "", "P4 BMI Category Not Correct");
            Assert.AreEqual(P5_expected, P5_actual, "", "P5 BMI Category Not Correct");
        }

        // Test Case A4: BMI Category - Obese, epsilon = 0.1, [30, infinity)
        [TestMethod]
        [TestCategory("A4")]
        public void BMICategory_Obese_ShouldEqualExpected()
        {
            // Arrange
            double P1_bmi = 29.9;
            double P2_bmi = 30;
            double P3_bmi = 30.1;
            double P4_bmi = 40;

            string P1_expected = "Overweight";
            string P2ToP4_expected = "Obese";

            BodyMassIndex P1_bodyMassIndex = new BodyMassIndex(P1_bmi);
            BodyMassIndex P2_bodyMassIndex = new BodyMassIndex(P2_bmi);
            BodyMassIndex P3_bodyMassIndex = new BodyMassIndex(P3_bmi);
            BodyMassIndex P4_bodyMassIndex = new BodyMassIndex(P4_bmi);

            // Act
            P1_bodyMassIndex.DisplayBMIAndCategory();
            P2_bodyMassIndex.DisplayBMIAndCategory();
            P3_bodyMassIndex.DisplayBMIAndCategory();
            P4_bodyMassIndex.DisplayBMIAndCategory();

            // Assert
            string P1_actual = P1_bodyMassIndex.getCategory;
            string P2_actual = P2_bodyMassIndex.getCategory;
            string P3_actual = P3_bodyMassIndex.getCategory;
            string P4_actual = P4_bodyMassIndex.getCategory;

            Assert.AreEqual(P1_expected, P1_actual, "", "P1 BMI Category Not Correct");
            Assert.AreEqual(P2ToP4_expected, P2_actual, "", "P2 BMI Category Not Correct");
            Assert.AreEqual(P2ToP4_expected, P3_actual, "", "P3 BMI Category Not Correct");
            Assert.AreEqual(P2ToP4_expected, P4_actual, "", "P4 BMI Category Not Correct");
        }

        // Test Case A5 Point 1: Calculate Body Mass Index - Input: Feet, Inches, Pounds, epsilon = 1, [0, infinity), Tolerable Difference: 0.09
        [TestMethod]
        [TestCategory("A5")]
        public void CalculateBodyMassIndex_TestA5Point1_ShouldEqualExpected()
        {
            // Arrange
            int feet = 5;
            int inches = 0;
            int pounds = 92;

            double expected = 18.4;

            BodyMassIndex A5 = new BodyMassIndex(feet, inches, pounds);

            // Act
            A5.CalculateBodyMassIndex();

            // Assert
            double actual = A5.getBodyMassIndex;
            Assert.AreEqual(expected, actual, 0.09, "BMI calculated outside the tolerable difference");
            Console.WriteLine("Test Case A5 Point 1:\tExpected {0:0.##}\t Actual {0:0.##}", expected, actual);
        }

        // Test Case A5 Point 2: Calculate Body Mass Index - Input: Feet, Inches, Pounds, epsilon = 1, [0, infinity), Tolerable Difference: 0.09
        [TestMethod]
        [TestCategory("A5")]
        public void CalculateBodyMassIndex_TestA5Point2_ShouldEqualExpected()
        {
            // Arrange
            int feet = 5;
            int inches = 5;
            int pounds = 109;

            double expected = 18.5;

            BodyMassIndex A5 = new BodyMassIndex(feet, inches, pounds);

            // Act
            A5.CalculateBodyMassIndex();

            // Assert
            double actual = A5.getBodyMassIndex;
            Assert.AreEqual(expected, actual, 0.09, "BMI calculated outside the tolerable difference");
            Console.WriteLine("Test Case A5 Point 2:\tExpected {0:0.##}\t Actual {0:0.##}", expected, actual);
        }

        // Test Case A5 Point 3: Calculate Body Mass Index - Input: Feet, Inches, Pounds, epsilon = 1, [0, infinity), Tolerable Difference: 0.09
        [TestMethod]
        [TestCategory("A5")]
        public void CalculateBodyMassIndex_TestA5Point3_ShouldEqualExpected()
        {
            // Arrange
            int feet = 5;
            int inches = 9;
            int pounds = 123;

            double expected = 18.6;

            BodyMassIndex A5 = new BodyMassIndex(feet, inches, pounds);

            // Act
            A5.CalculateBodyMassIndex();

            // Assert
            double actual = A5.getBodyMassIndex;
            Assert.AreEqual(expected, actual, 0.09, "BMI calculated outside the tolerable difference");
            Console.WriteLine("Test Case A5 Point 3:\tExpected {0:0.##}\t Actual {0:0.##}", expected, actual);
        }

        // Test Case A5 Point 4: Calculate Body Mass Index - Input: Feet, Inches, Pounds, epsilon = 1, [0, infinity), Tolerable Difference: 0.09
        [TestMethod]
        [TestCategory("A5")]
        public void CalculateBodyMassIndex_TestA5Point4_ShouldEqualExpected()
        {
            // Arrange
            int feet = 6;
            int inches = 0;
            int pounds = 179;

            double expected = 24.9;

            BodyMassIndex A5 = new BodyMassIndex(feet, inches, pounds);

            // Act
            A5.CalculateBodyMassIndex();

            // Assert
            double actual = A5.getBodyMassIndex;
            Assert.AreEqual(expected, actual, 0.09, "BMI calculated outside the tolerable difference");
            Console.WriteLine("Test Case A5 Point 4:\tExpected {0:0.##}\t Actual {0:0.##}", expected, actual);
        }

        // Test Case A5 Point 5: Calculate Body Mass Index - Input: Feet, Inches, Pounds, epsilon = 1, [0, infinity), Tolerable Difference: 0.09
        [TestMethod]
        [TestCategory("A5")]
        public void CalculateBodyMassIndex_TestA5Point5_ShouldEqualExpected()
        {
            // Arrange
            int feet = 6;
            int inches = 2;
            int pounds = 190;

            double expected = 25;

            BodyMassIndex A5 = new BodyMassIndex(feet, inches, pounds);

            // Act
            A5.CalculateBodyMassIndex();

            // Assert
            double actual = A5.getBodyMassIndex;
            Assert.AreEqual(expected, actual, 0.09, "BMI calculated outside the tolerable difference");
            Console.WriteLine("Test Case A5 Point 5:\tExpected {0:0.##}\t Actual {0:0.##}", expected, actual);
        }

        // Test Case A5 Point 6: Calculate Body Mass Index - Input: Feet, Inches, Pounds, epsilon = 1, [0, infinity), Tolerable Difference: 0.09
        [TestMethod]
        [TestCategory("A5")]
        public void CalculateBodyMassIndex_TestA5Point6_ShouldEqualExpected()
        {
            // Arrange
            int feet = 6;
            int inches = 3;
            int pounds = 233;

            double expected = 29.9;

            BodyMassIndex A5 = new BodyMassIndex(feet, inches, pounds);

            // Act
            A5.CalculateBodyMassIndex();

            // Assert
            double actual = A5.getBodyMassIndex;
            Assert.AreEqual(expected, actual, 0.09, "BMI calculated outside the tolerable difference");
            Console.WriteLine("Test Case A5 Point 6:\tExpected {0:0.##}\t Actual {0:0.##}", expected, actual);
        }

        // Test Case A5 Point 7: Calculate Body Mass Index - Input: Feet, Inches, Pounds, epsilon = 1, [0, infinity), Tolerable Difference: 0.09
        [TestMethod]
        [TestCategory("A5")]
        public void CalculateBodyMassIndex_TestA5Point7_ShouldEqualExpected()
        {
            // Arrange
            int feet = 6;
            int inches = 5;
            int pounds = 247;

            double expected = 30;

            BodyMassIndex A5 = new BodyMassIndex(feet, inches, pounds);

            // Act
            A5.CalculateBodyMassIndex();

            // Assert
            double actual = A5.getBodyMassIndex;
            Assert.AreEqual(expected, actual, 0.09, "BMI calculated outside the tolerable difference");
            Console.WriteLine("Test Case A5 Point 7:\tExpected {0:0.##}\t Actual {0:0.##}", expected, actual);
        }
    }

    // Retirement Age Unit Test
    [TestClass]
    public class RetirementAgeTests
    {
        // Test Case B1 Point 1: Calculate if Retirement Goal Will Be Met, epsilon = 0.01, (0, 99], Tolerable Difference: 0
        [TestMethod]
        [TestCategory("B1")]
        public void CalculateRetirementAge_TestB1Point1_ShouldEqualExpected()
        {
            // Arrange
            double age = 1;
            double salary = 10000;
            double percentSaved = 10;
            double savingsGoal = 1000000;

            RetirementAge B1 = new RetirementAge(age, salary, percentSaved, savingsGoal);

            // Act
            B1.CalculateRetirementAge();
            B1.DisplayRetirementInfo();

            // Assert
            bool actual = B1.getRetirementGoal;
            Assert.IsTrue(actual);
            Console.WriteLine("Test Case B1 Point 1:\tActual {0}", actual);
        }

        // Test Case B1 Point 2: Calculate if Retirement Goal Will Be Met, epsilon = 0.01, (0, 99], Tolerable Difference: 0
        [TestMethod]
        [TestCategory("B1")]
        public void CalculateRetirementAge_TestB1Point2_ShouldEqualExpected()
        {
            // Arrange
            double age = 22;
            double salary = 50000;
            double percentSaved = 10;
            double savingsGoal = 1000000;

            RetirementAge B1 = new RetirementAge(age, salary, percentSaved, savingsGoal);

            // Act
            B1.CalculateRetirementAge();
            B1.DisplayRetirementInfo();

            // Assert
            bool actual = B1.getRetirementGoal;
            Assert.IsTrue(actual);
            Console.WriteLine("Test Case B1 Point 1:\tActual {0}", actual);
        }

        // Test Case B1 Point 3: Calculate if Retirement Goal Will Be Met, epsilon = 0.01, (0, 99], Tolerable Difference: 0
        [TestMethod]
        [TestCategory("B1")]
        public void CalculateRetirementAge_TestB1Point3_ShouldEqualExpected()
        {
            // Arrange
            double age = 25;
            double salary = 70000;
            double percentSaved = 15;
            double savingsGoal = 1000000;

            RetirementAge B1 = new RetirementAge(age, salary, percentSaved, savingsGoal);

            // Act
            B1.CalculateRetirementAge();
            B1.DisplayRetirementInfo();

            // Assert
            bool actual = B1.getRetirementGoal;
            Assert.IsTrue(actual);
            Console.WriteLine("Test Case B1 Point 1:\tActual {0}", actual);
        }

        // Test Case B1 Point 4: Calculate if Retirement Goal Will Be Met, epsilon = 0.01, (0, 99], Tolerable Difference: 0
        [TestMethod]
        [TestCategory("B1")]
        public void CalculateRetirementAge_TestB1Point4_ShouldEqualExpected()
        {
            // Arrange
            double age = 35;
            double salary = 80000;
            double percentSaved = 15;
            double savingsGoal = 1000000;

            RetirementAge B1 = new RetirementAge(age, salary, percentSaved, savingsGoal);

            // Act
            B1.CalculateRetirementAge();
            B1.DisplayRetirementInfo();

            // Assert
            bool actual = B1.getRetirementGoal;
            Assert.IsTrue(actual);
            Console.WriteLine("Test Case B1 Point 1:\tActual {0}", actual);
        }

        // Test Case B1 Point 5: Calculate if Retirement Goal Will Be Met, epsilon = 0.01, (0, 99], Tolerable Difference: 0
        [TestMethod]
        [TestCategory("B1")]
        public void CalculateRetirementAge_TestB1Point5_ShouldEqualExpected()
        {
            // Arrange
            double age = 50;
            double salary = 100000;
            double percentSaved = 20;
            double savingsGoal = 1000000;

            RetirementAge B1 = new RetirementAge(age, salary, percentSaved, savingsGoal);

            // Act
            B1.CalculateRetirementAge();
            B1.DisplayRetirementInfo();

            // Assert
            bool actual = B1.getRetirementGoal;
            Assert.IsTrue(actual);
            Console.WriteLine("Test Case B1 Point 1:\tActual {0}", actual);
        }

        // Test Case B1 Point 6: Calculate if Retirement Goal Will Be Met, epsilon = 0.01, (0, 99], Tolerable Difference: 0
        [TestMethod]
        [TestCategory("B1")]
        public void CalculateRetirementAge_TestB1Point6_ShouldEqualExpected()
        {
            // Arrange
            double age = 75;
            double salary = 110000;
            double percentSaved = 20;
            double savingsGoal = 1000000;

            RetirementAge B1 = new RetirementAge(age, salary, percentSaved, savingsGoal);

            // Act
            B1.CalculateRetirementAge();
            B1.DisplayRetirementInfo();

            // Assert
            bool actual = B1.getRetirementGoal;
            Assert.IsTrue(actual);
            Console.WriteLine("Test Case B1 Point 1:\tActual {0}", actual);
        }

        // Test Case B1 Point 7: Calculate if Retirement Goal Will Be Met, epsilon = 0.01, (0, 99], Tolerable Difference: 0
        [TestMethod]
        [TestCategory("B1")]
        public void CalculateRetirementAge_TestB1Point7_ShouldEqualExpected()
        {
            // Arrange
            double age = 85;
            double salary = 120000;
            double percentSaved = 25;
            double savingsGoal = 1000000;

            RetirementAge B1 = new RetirementAge(age, salary, percentSaved, savingsGoal);

            // Act
            B1.CalculateRetirementAge();
            B1.DisplayRetirementInfo();

            // Assert
            bool actual = B1.getRetirementGoal;
            Assert.IsTrue(actual);
            Console.WriteLine("Test Case B1 Point 1:\tActual {0}", actual);
        }
    }
}
