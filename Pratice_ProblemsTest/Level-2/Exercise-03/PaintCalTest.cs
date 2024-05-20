using System;
using Practice_ProblemLogic;

namespace Practice_ProblemTest
{
    [TestClass]
    public class PaintCalTest
    {
        [TestMethod]
        public void Test_PaintCal()
        {
            //Arrange
            int length = 10;
            int width = 20;
            int Expected = 1;

            //Act
            int values = SelfcheckTest.CountsPaint(length, width);

            //Assert
            Assert.AreEqual(Expected, values);
        }
    } 
}