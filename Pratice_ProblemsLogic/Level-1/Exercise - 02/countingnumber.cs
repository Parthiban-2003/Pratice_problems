using System;

namespace Pratice_ProblemLogic;

public static class countingnumber
{
    #region Publics
    public static int Solution(string strName)
    {
        int count = 0;

        foreach(char words in strName)
        {
            count++;
        }
        return count;
        #endregion
    }

}
 
