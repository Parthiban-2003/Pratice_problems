using System;

namespace Practice_ProblemsLogic
{
    public class PaintCal
    {
        public static int CALCCount(int people, int person,int pieces, int totalSlices)
        {
            int slicesPerPerson = totalSlices / people;
            int leftOvers = totalSlices % people;

            return leftOvers;
        }
    }
}

