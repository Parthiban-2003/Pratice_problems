
using Pratice_ProblemsLogic;

namespace Pratice_ProblemsTest;

[TestClass]
public class quoteTest
{
    #region Tests
    [TestMethod]
    public void Test_quote()
    {
        // Arrange
         string author = "leodas";
         string quotes = "Naa avan illa";
         string expected = "leodas says, \"Naa avan illa\"";
      
        // Act
        string result = quote.Printing(author, quotes);

        // Assert
        Assert.AreEqual(expected, result);
    }
    #endregion
}



