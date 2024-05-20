using System;
using Pratice_ProblemLogic;

namespace Pratice_ProblemsLogic
{
    [TestClass]
    public class storyTest
    {
        [TestMethod]
        public void Test_story()
        {
            //Arrange

            string noun = "dog";
            string verb = "walk";
            string adjective = "blue";
            string adverb = "quickly";
            string expected = "Do you walk your blue dog quickly? That's hilarious!";

            //act
            string message = story.MadLib(noun,verb,adjective, adverb);

            //Assert
            Assert.AreEqual(expected, message);
        }
    }
}