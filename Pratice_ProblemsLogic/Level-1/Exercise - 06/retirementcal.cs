using System;

namespace Practice_ProblemLogic
{
    public static class retirementcal
    {
        public static int Calretirement(int currentAge, int retirementAge)
        {
            return retirementAge - currentAge;
        }

        public static int CalretirementYear(int currentYear, int yearsRetirement)
        {
            return currentYear + yearsRetirement;
        }
    }
}
