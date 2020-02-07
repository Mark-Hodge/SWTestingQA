using Microsoft.VisualStudio.TestTools.UnitTesting;
using SWTestingQA_assignment2;

namespace assignment2_UnitTests
{
    [TestClass]
    public class BodyMassIndexTests
    {
        [TestMethod]
        public void CalculateBodyMassIndex_WhenArgumentsCorrect_ShouldEqualExpected()
        {
            // Arrange
            int usrFeet = 5;
            int usrInches = 3;
            double usrPounds = 125.0;
            double expected = 22.7;
            BodyMassIndex bodyMassIndex = new BodyMassIndex(usrFeet, usrInches, usrPounds);

            // Act
            bodyMassIndex.CalculateBodyMassIndex();

            // Assert
            double actual = bodyMassIndex.getBodyMassIndex;
            Assert.AreEqual(expected, actual, 0.1, "BMI not calculated correctly");
        }

        [TestMethod]
        public void DisplayBMIAndCategory_WhenArgumentsCorrect_ShouldEqualExpected()
        {
            // Arrange
            int usrFeet = 5;
            int usrInches = 3;
            double usrPounds = 125.0;
            string expected = "Normal Weight";
            BodyMassIndex bodyMassIndex = new BodyMassIndex(usrFeet, usrInches, usrPounds);

            // Act
            bodyMassIndex.CalculateBodyMassIndex();
            bodyMassIndex.DisplayBMIAndCategory();

            // Assert
            string actual = bodyMassIndex.getCategory;
            Assert.AreEqual(expected, actual, " ", "BMI category not set correctly");
        }
    }
}
