using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using Assignment3_WebApp_Official.Models;
using Assignment3_WebApp_Official.Controllers;
using System;


namespace Assignment3_WebApp_Official_TestProject
{
    [TestClass]
    public class BMICalculator_UnitTests
    {
        // Test for underweight BMI
        [TestMethod]
        [TestCategory("BMI")]
        public void BMI_WhenValuesBorderUnderBound_ShouldBeUnderweight()
        {
            // Arrange
            int feet = 5; int inches = 6; int weight = 111;
            double result = 18.35; string category = "Underweight";

            BMI bmi = new BMI();
            bmi.heightFeet = feet; bmi.heightInches = inches; bmi.weightPounds = weight;

            Tuple<double, string> expected = Tuple.Create(result, category);

            // Act
            Tuple<double, string> actual = bmi.BMITest();

            // Assert
            Assert.AreEqual(expected.Item1, actual.Item1, 0.125, "Value of BMI does not match expected.");
            Assert.AreEqual(expected.Item2, actual.Item2, "", "Value of Category does not match expected.");
        }

        // Test for Normalweight BMI
        [TestMethod]
        [TestCategory("BMI")]
        public void BMI_WhenValuesBorderNormalBound_ShouldBeNormalweight()
        {
            // Arrange
            int feet = 5; int inches = 5; int weight = 109;
            double result = 18.58; string category = "Normalweight";

            BMI bmi = new BMI();
            bmi.heightFeet = feet; bmi.heightInches = inches; bmi.weightPounds = weight;

            Tuple<double, string> expected = Tuple.Create(result, category);

            // Act
            Tuple<double, string> actual = bmi.BMITest();

            // Assert
            Assert.AreEqual(expected.Item1, actual.Item1, 0.125, "Value of BMI does not match expected.");
            Assert.AreEqual(expected.Item2, actual.Item2, "", "Value of Category does not match expected.");
        }

        // Test for Overweight BMI
        [TestMethod]
        [TestCategory("BMI")]
        public void BMI_WhenValuesExceedNormalBound_ShouldBeOverweight()
        {
            // Arrange
            int feet = 5; int inches = 11; int weight = 175;
            double result = 25.0; string category = "Overweight";

            BMI bmi = new BMI();
            bmi.heightFeet = feet; bmi.heightInches = inches; bmi.weightPounds = weight;

            Tuple<double, string> expected = Tuple.Create(result, category);

            // Act
            Tuple<double, string> actual = bmi.BMITest();

            // Assert
            Assert.AreEqual(expected.Item1, actual.Item1, 0.125, "Value of BMI does not match expected.");
            Assert.AreEqual(expected.Item2, actual.Item2, "", "Value of Category does not match expected.");
        }

        // Test for Obese BMI
        [TestMethod]
        [TestCategory("BMI")]
        public void BMI_WhenValuesExceedOverBound_ShouldBeObese()
        {
            // Arrange
            int feet = 6; int inches = 0; int weight = 216;
            double result = 30.0; string category = "Obese";

            BMI bmi = new BMI();
            bmi.heightFeet = feet; bmi.heightInches = inches; bmi.weightPounds = weight;

            Tuple<double, string> expected = Tuple.Create(result, category);

            // Act
            Tuple<double, string> actual = bmi.BMITest();

            // Assert
            Assert.AreEqual(expected.Item1, actual.Item1, 0.125, "Value of BMI does not match expected.");
            Assert.AreEqual(expected.Item2, actual.Item2, "", "Value of Category does not match expected.");
        }

        // Test for Unknown BMI
        [TestMethod]
        [TestCategory("BMI")]
        public void BMI_WhenValuesNonComputable_ShouldBeNotCategorized()
        {
            // Arrange
            int feet = 6; int inches = 0; int weight = -216;
            double result = -30.0; string category = "NotCategorized";

            BMI bmi = new BMI();
            bmi.heightFeet = feet; bmi.heightInches = inches; bmi.weightPounds = weight;

            Tuple<double, string> expected = Tuple.Create(result, category);

            // Act
            Tuple<double, string> actual = bmi.BMITest();

            // Assert
            Assert.AreEqual(expected.Item1, actual.Item1, 0.125, "Value of BMI does not match expected.");
            Assert.AreEqual(expected.Item2, actual.Item2, "", "Value of Category does not match expected.");
        }
    }

    [TestClass]
    public class RETCalculator_UnitTests
    {
        // Test Retirement Age lower bound
        [TestMethod]
        [TestCategory("RET")]
        public void RET_WhenValuesBorderBound_ShouldMeetGoal()
        {
            // Arrange
            int age = 23; double salary = 80000; double saved = 18.5; double goal = 1500000;
            double result = 99; bool willMeetGoal = true;

            RET ret = new RET();
            ret.age = age; ret.salary = salary; ret.saved = saved; ret.goal = goal;

            Tuple<double, bool> expected = Tuple.Create(result, willMeetGoal);

            // Act
            Tuple<double, bool> actual = ret.RETTest();

            // Assert
            Assert.AreEqual(expected.Item1, actual.Item1, 0.125, "Value of RET does not match expected.");
            Assert.AreEqual(expected.Item2, actual.Item2, "", "Value of Goal does not match expected.");
        }

        // Test Retirement Age upper bound
        [TestMethod]
        [TestCategory("RET")]
        public void RET_WhenValuesExceedBound_ShouldNotMeetGoal()
        {
            // Arrange
            int age = 23; double salary = 80000; double saved = 18.2; double goal = 1500000;
            double result = 100; bool willMeetGoal = false;

            RET ret = new RET();
            ret.age = age; ret.salary = salary; ret.saved = saved; ret.goal = goal;

            Tuple<double, bool> expected = Tuple.Create(result, willMeetGoal);

            // Act
            Tuple<double, bool> actual = ret.RETTest();

            // Assert
            Assert.AreEqual(expected.Item1, actual.Item1, 0.125, "Value of RET does not match expected.");
            Assert.AreEqual(expected.Item2, actual.Item2, "", "Value of Goal does not match expected.");
        }
    }

    [TestClass]
    public class ControllerHomeTests
    {
        // Test HomeController - Index
        [TestMethod]
        [TestCategory("Controller")]
        public void Index_ReturnsAViewResult_ViewResultIsNotNull()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        // Test HomeController - About
        [TestMethod]
        [TestCategory("Controller")]
        public void About_ReturnsAViewResult_ViewResultIsNotNull()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        // Test HomeController - BMI
        [TestMethod]
        [TestCategory("Controller")]
        public void BMI_ReturnsAViewResult_ViewResultIsNotNull()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.BMI() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        // Test HomeController - BMI HttpPost Null
        [TestMethod]
        [TestCategory("Controller")]
        public void BMIHttpPost_ReturnsAViewResult_ViewResultIsNotNull_ObjectIsNull()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.BMI(bmi: null) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        // Test HomeController - BMI HttpPost Not Null
        [TestMethod]
        [TestCategory("Controller")]
        public void BMIHttpPost_ReturnsAViewResult_ViewResultIsNotNull_ObjectIsNotNull()
        {
            // Arrange
            HomeController controller = new HomeController();
            BMI bmi = new BMI();

            // Act
            ViewResult result = controller.BMI(bmi) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        // Test HomeController - RET
        [TestMethod]
        [TestCategory("Controller")]
        public void RET_ReturnsAViewResult_ViewResultIsNotNull()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.RET() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        // Test HomeController - RET HttpPost Null
        [TestMethod]
        [TestCategory("Controller")]
        public void RETHttpPost_ReturnsAViewResult_ViewResultIsNotNull_ObjectIsNull()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.RET(ret: null) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        // Test HomeController - RET HttpPost Not Null
        [TestMethod]
        [TestCategory("Controller")]
        public void RETHttpPost_ReturnsAViewResult_ViewResultIsNotNull_ObjectIsNotNull()
        {
            // Arrange
            HomeController controller = new HomeController();
            RET ret = new RET();

            // Act
            ViewResult result = controller.RET(ret) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }

    [TestClass]
    public class ViewHomeTests
    {
        // Test HomeView - About
        [TestMethod]
        [TestCategory("View")]
        public void About_RendersView_ViewDataIsValid()
        {
            // Arange
            HomeController controller = new HomeController();

            // Act
            var result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual(result.ViewData["Title"], "Development Lifecyle Information");
            Assert.AreEqual(result.ViewData["Message"], "Application Details");
        }

        // Test HomeView - BMI
        [TestMethod]
        [TestCategory("View")]
        public void BMI_RendersView_ViewDataIsValid()
        {
            // Arange
            HomeController controller = new HomeController();

            // Act
            var result = controller.BMI() as ViewResult;

            // Assert
            Assert.AreEqual(result.ViewData["Title"], "Body Mass Index Calculator");
            Assert.AreEqual(result.ViewData["Message"], "Your BMI page");
        }

        // Test HomeView - RET
        [TestMethod]
        [TestCategory("View")]
        public void RET_RendersView_ViewDataIsValid()
        {
            // Arange
            HomeController controller = new HomeController();

            // Act
            var result = controller.RET() as ViewResult;

            // Assert
            Assert.AreEqual(result.ViewData["Title"], "Retirement Calculator");
            Assert.AreEqual(result.ViewData["Message"], "Your Retirement page");
        }
    }
}
