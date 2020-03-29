using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Assignment3_WebApp_Official_TestProject
{
    [TestClass]
    public class BMIFormInterfaceTests
    {
        private IWebDriver driver;
        public string url = "https://assignment3-webapp-dev.azurewebsites.net";

        // Test User Interface - BMI Form - For Lower Bound Input
        [TestMethod]
        [TestCategory("Interface")]
        public void BMIForm_InterfaceTest_ShouldNotAcceptNegativeValues()
        {
            // Arrange
            string expected = "Your BMI page";

            driver = new ChromeDriver();
            url = url + "/Home/BMI";
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();

            // Act
            driver.FindElement(By.Id("heightFeet")).SendKeys("-1");
            driver.FindElement(By.Id("heightInches")).SendKeys("-1");
            driver.FindElement(By.Id("weightPounds")).SendKeys("-1");
            driver.FindElement(By.Id("submit")).Click();

            string actual = driver.FindElement(By.CssSelector("h3")).GetAttribute("innerText");

            // Assert
            Assert.AreEqual(expected, actual, "Expected result does not match actual result");
            driver.Close(); driver.Dispose(); driver.Quit();
        }

        // Test User Interface - BMI Form - For Upper Bound Input
        [TestMethod]
        [TestCategory("Interface")]
        public void BMIForm_InterfaceTest_ShouldNotAcceptExceedingValues()
        {
            // Arrange
            string expected = "Your BMI page";

            driver = new ChromeDriver();
            url = url + "/Home/BMI";
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();

            // Act
            driver.FindElement(By.Id("heightFeet")).SendKeys("13");
            driver.FindElement(By.Id("heightInches")).SendKeys("13");
            driver.FindElement(By.Id("weightPounds")).SendKeys("1000");
            driver.FindElement(By.Id("submit")).Click();

            string actual = driver.FindElement(By.CssSelector("h3")).GetAttribute("innerText");

            // Assert
            Assert.AreEqual(expected, actual, "Expected result does not match actual result");
            driver.Close(); driver.Dispose(); driver.Quit();
        }

        // Test User Interface - BMI Form - For Valid Input
        [TestMethod]
        [TestCategory("Interface")]
        public void BMIForm_InterfaceTest_ShouldAcceptValidInputValues()
        {
            // Arrange
            string expected = "Your BMI is 23.7, You are Normalweight";

            driver = new ChromeDriver();
            url = url + "/Home/BMI";
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();

            // Act
            driver.FindElement(By.Id("heightFeet")).SendKeys("6");
            driver.FindElement(By.Id("heightInches")).SendKeys("2");
            driver.FindElement(By.Id("weightPounds")).SendKeys("180");
            driver.FindElement(By.Id("submit")).Click();

            string actual = driver.FindElement(By.CssSelector("h3")).GetAttribute("innerText");

            // Assert
            Assert.AreEqual(expected, actual, "Expected result does not match actual result");
            driver.Close(); driver.Dispose(); driver.Quit();
        }
    }

    [TestClass]
    public class RETFormInterfaceTests
    {
        private IWebDriver driver;
        public string url = "https://assignment3-webapp-dev.azurewebsites.net";

        // Test User Interface - RET Form - For Lower Bound Input
        [TestMethod]
        [TestCategory("Interface")]
        public void RETForm_InterfaceTest_ShouldNotAcceptNegativeValues()
        {
            // Arrange
            string expected = "Your Retirement page";

            driver = new ChromeDriver();
            url = url + "/Home/RET";
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();

            // Act
            driver.FindElement(By.Id("age")).SendKeys("-1");
            driver.FindElement(By.Id("salary")).SendKeys("-1");
            driver.FindElement(By.Id("saved")).SendKeys("-1");
            driver.FindElement(By.Id("goal")).SendKeys("-1");
            driver.FindElement(By.Id("submit")).Click();

            string actual = driver.FindElement(By.CssSelector("h3")).GetAttribute("innerText");

            // Assert
            Assert.AreEqual(expected, actual, "Expected result does not match actual result");
            driver.Close(); driver.Dispose(); driver.Quit();
        }

        // Test User Interface - RET Form - For Upper Bound Input
        [TestMethod]
        [TestCategory("Interface")]
        public void RETForm_InterfaceTest_ShouldNotAcceptExceedingValues()
        {
            // Arrange
            string expected = "Your Retirement page";

            driver = new ChromeDriver();
            url = url + "/Home/RET";
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();

            // Act
            driver.FindElement(By.Id("age")).SendKeys("99");
            driver.FindElement(By.Id("salary")).SendKeys("100000000000001");
            driver.FindElement(By.Id("saved")).SendKeys("101");
            driver.FindElement(By.Id("goal")).SendKeys("100000000000001");
            driver.FindElement(By.Id("submit")).Click();

            string actual = driver.FindElement(By.CssSelector("h3")).GetAttribute("innerText");

            // Assert
            Assert.AreEqual(expected, actual, "Expected result does not match actual result");
            driver.Close(); driver.Dispose(); driver.Quit();
        }

        // Test User Interface - RET Form - For Valid Input
        [TestMethod]
        [TestCategory("Interface")]
        public void RETForm_InterfaceTest_ShouldAcceptValidInputValues()
        {
            // Arrange
            string expected = "The age you could retire is 93, It is likely your goal will be met";

            driver = new ChromeDriver();
            url = url + "/Home/RET";
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();

            // Act
            driver.FindElement(By.Id("age")).SendKeys("22");
            driver.FindElement(By.Id("salary")).SendKeys("70000");
            driver.FindElement(By.Id("saved")).SendKeys("15");
            driver.FindElement(By.Id("goal")).SendKeys("1000000");
            driver.FindElement(By.Id("submit")).Click();

            string actual = driver.FindElement(By.CssSelector("h3")).GetAttribute("innerText");

            // Assert
            Assert.AreEqual(expected, actual, "Expected result does not match actual result");
            driver.Close(); driver.Dispose(); driver.Quit();
        }
    }

    [TestClass]
    public class NavbarRedirectTests
    {
        private IWebDriver driver;
        public string url = "https://assignment3-webapp-dev.azurewebsites.net";

        // Test User Interface - Navbar - For Proper redirects
        [TestMethod]
        [TestCategory("Interface")]
        public void Navbar_InterfaceTests_ShouldRedirectToExpectedURL()
        {
            // Arrange
            string brandExpected = url + "/"; string homeExpected = url + "/"; string aboutExpected = url + "/Home/About";
            string bmiExpected = url + "/Home/BMI"; string retExpected = url + "/Home/RET";

            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();

            // Act
            string brandActual = driver.FindElement(By.Id("brandRedirect")).GetAttribute("href");
            string homeActual = driver.FindElement(By.Id("homeRedirect")).GetAttribute("href");
            string aboutActual = driver.FindElement(By.Id("aboutRedirect")).GetAttribute("href");
            string bmiActual = driver.FindElement(By.Id("bmiRedirect")).GetAttribute("href");
            string retActual = driver.FindElement(By.Id("retRedirect")).GetAttribute("href");

            // Assert
            Assert.AreEqual(brandExpected, brandActual, "Expected result does not match actual result");
            Assert.AreEqual(homeExpected, homeActual, "Expected result does not match actual result");
            Assert.AreEqual(aboutExpected, aboutActual, "Expected result does not match actual result");
            Assert.AreEqual(bmiExpected, bmiActual, "Expected result does not match actual result");
            Assert.AreEqual(retExpected, retActual, "Expected result does not match actual result");

            driver.Close(); driver.Dispose(); driver.Quit();
        }

        // Test User Interface - Body - For Proper redirects
        [TestMethod]
        [TestCategory("Interface")]
        public void Body_InterfaceTests_ShouldRedirectToExpectedURL()
        {
            // Arrange
            string documentationExpected = "https://github.com/Mark-Hodge/SWTestingQA/blob/master/README.md";
            string sourcecodeExpected = "https://github.com/Mark-Hodge/SWTestingQA"; string instructionsExpected = url + "/Home/About";

            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();

            // Act
            string documentationActual = driver.FindElement(By.Id("body-documentation-redirect")).GetAttribute("href");
            string sourcecodeActual = driver.FindElement(By.Id("body-sourcecode-redirect")).GetAttribute("href");
            string instructionsActual = driver.FindElement(By.Id("body-instructions-redirect")).GetAttribute("href");

            // Assert
            Assert.AreEqual(documentationExpected, documentationActual, "Expected result does not match actual result");
            Assert.AreEqual(sourcecodeExpected, sourcecodeActual, "Expected result does not match actual result");
            Assert.AreEqual(instructionsExpected, instructionsActual, "Expected result does not match actual result");

            driver.Close(); driver.Dispose(); driver.Quit();
        }
    }
}
