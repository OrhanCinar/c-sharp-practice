using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class FindNumberSolutionLinearEquation2
    {
        int CountSol(int[] coeff, int n, int rhs)
        {
            int[] dp = new int[rhs + 1];
            dp[0] = 1;

            for (int i = 0; i < n; i++)
            {
                for (int j = coeff[i]; j < rhs; j++)
                {
                    dp[j] += dp[j - coeff[i]];
                }
            }

            return dp[rhs];
        }
    }

}
