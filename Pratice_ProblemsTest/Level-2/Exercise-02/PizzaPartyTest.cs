using System;
using System.IO.Pipes;
using Practice_ProblemsLogic;

namespace Practice_ProblemTest
{
    [TestClass]
    public class PaintCalTests
    {
        [TestMethod]
        public void Test_PizzaParty()
        {
            // Arrange
            int people = 8;
            int pizza = 3;
            int pieces = 8;
            int totalSlices = pizza * pieces;
            int left = people % pieces;

            // Act
            int leftovers = PaintCal.CALCCount(people, pizza, pieces, totalSlices);

            // Assert
            Assert.AreEqual(left, leftovers);
        }
    }
}
