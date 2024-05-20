using System;

namespace Practice_ProblemLogic
{
    [TestClass]
    public class RectTest
    {
        [TestMethod]
        public void Test_Rect()
        {
            //Arrange

            int length = 15;
            int width = 20;
            int expected = 300;

            //Act

            int Msg = Convert.ToInt32(PizzaParty.AreaOfRect(length, width));

            //Assert

            Assert.AreEqual(expected, Msg);
        }
        [TestMethod]
        public void Test_math()
        {
            //Arrange

            int expected = 300;
            double number = 0.09290304;
            double Ans = 27.870912;

            //Act

            double Message = PizzaParty.math(expected, number);

            //Assert

            Assert.AreEqual(Ans, Message);
        }
    }
}