
using System;
using Practice_ProblemsLogic;

namespace Practice_ProblemLogic
{
    public static class PaintCal
    {
        private static int _nNumber = 10;
        private const int GALLONS = 350;

        public static int CountsPaint(int nLength, int width)
        {
            int nCurrentVal = nLength * width;
            
            return RoundUp(nCurrentVal, GALLONS);
        }


        public static int RoundUp(int neumerator, int demoniator)
        {
            return (neumerator + demoniator - 1) / demoniator;

           
        }
    }
}