using System;
using Practice_ProblemLogic;

namespace Practice_ProblemLogicTests
{
    [TestClass]
    public class retirementCalTest
    {
        [TestMethod]
        public void Test_CalculateYearsRetirement()
        {
            // Arrange
            int currentAge = 25;
            int retirementAge = 65;
            int difference = 40;

            // Act
            int yearsRetirement = retirementcal.Calretirement(currentAge, retirementAge);

            // Assert
            Assert.AreEqual(difference, yearsRetirement);
        }

        [TestMethod]
        public void Test_retirementcal()
        {
            // Arrange
            int currentYear = 2020;
            int yearsRetirement = 40;
            int expectedRetirementYear = 2060;

            // Act
            int retirementYear = retirementcal.CalretirementYear(currentYear, yearsRetirement);

            // Assert
            Assert.AreEqual(expectedRetirementYear, retirementYear);
        }
    }
}
