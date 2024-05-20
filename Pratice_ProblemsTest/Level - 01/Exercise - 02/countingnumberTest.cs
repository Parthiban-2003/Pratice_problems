using Pratice_ProblemsTest;
using Pratice_ProblemLogic;

namespace Pratice_ProblemTest;

[TestClass]
public class countingnumberTest
{
    #region Tests
    [TestMethod]
    public void Test_countingnumber()
    {
        // Arrange
        string Names = "VIJAY";

        // Act
        int strMessage = Convert.ToInt32(countingnumber.Solution(Names));

        // Assert
        Assert.AreEqual(5, strMessage);
    }
    #endregion
}

