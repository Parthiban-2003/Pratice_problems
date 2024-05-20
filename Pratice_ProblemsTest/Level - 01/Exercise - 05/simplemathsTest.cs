
using Pratice_ProblemLogic;

namespace Pratice_ProblemsTest
{
    [TestClass]
    public class SimpleMathTest
    {
        [TestMethod]
        public void Test_Add()
        {
            // Arrange
            int num1 = 5;
            int num2 = 3;
            int expectedSum = 8;

            // Act
            int actualSum = SimpleMath.Add(num1, num2);

            // Assert
            Assert.AreEqual(expectedSum, actualSum);
        }

        [TestMethod]
        public void Test_Subtract()
        {
            // Arrange
            int val1 = 10;
            int val2 = 4;
            int expectedDifference = 6;

            // Act
            int actualDifference = SimpleMath.Subtract(val1, val2);

            // Assert
            Assert.AreEqual(expectedDifference, actualDifference);
        }

        [TestMethod]
        public void Test_Multiply()
        {
            // Arrange
            int val3 = 2;
            int val4 = 7;
            int expectedProduct = 14;

            // Act
            int actualProduct = SimpleMath.Multiply(val3, val4);

            // Assert
            Assert.AreEqual(expectedProduct, actualProduct);
        }

        [TestMethod]
        public void Test_Divide()
        {
            // Arrange
            int val5 = 10;
            int val6 = 2;
            int expectedQuotient = 5;

            // Act
            int actualQuotient = SimpleMath.Divide(val5, val6);

            // Assert
            Assert.AreEqual(expectedQuotient, actualQuotient);
        }

        [TestMethod]
        
        public void Test_Divide_ByZero()
        {
            // Arrange
            int val5 = 10;
            int val6 = 0;

            // Act
            int result = SimpleMath.Divide(val5, val6);

            
        }
    }
}
