using System;
using Practice_ProblemTest;

namespace Practice_ProblemLogic;

public class SelfcheckTest
{
    public void Test_Selfcheck()
    {
        //Arrange
        int qu1 = 10*1;
        int qu2 = 20*8;
        int qu3 = 25*3;
        int result = qu1 + qu2 + qu3;

        //Act
        int point = Selfcheck.Counters(qu1, qu2, qu3);

        //Assert
        Assert.AreEqual(result, point);
    }
}