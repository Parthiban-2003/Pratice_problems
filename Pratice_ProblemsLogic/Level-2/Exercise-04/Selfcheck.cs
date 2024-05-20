using System;

namespace Practice_ProblemLogic
{
    public class Selfcheck
    {
        public static int Counters(int item1,int item2,int item3,int qu1,int qu2,int qu3)
        {
            int val1 = item1 * qu1;
            int val2 = item2 * qu2;
            int val3 = item3 * qu3;
            int result = val1 + val2 + val3;

            return result;
        }
    }
}