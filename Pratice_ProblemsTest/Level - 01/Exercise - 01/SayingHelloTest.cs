using System;

namespace Pratice_ProblemLogic;

[TestClass]
public class SayingHelloTest
{
    #region Tests
    [TestMethod]
    public void Test_SayingHello()
    {
        // Arrange
        const string Names = "VIJAY";

        // Act
        string strMessage = SayingHello.Username(Names);

        // Assert
        Assert.AreEqual("Hello VIJAY, nice to meet you!", strMessage);
    }
    #endregion
}