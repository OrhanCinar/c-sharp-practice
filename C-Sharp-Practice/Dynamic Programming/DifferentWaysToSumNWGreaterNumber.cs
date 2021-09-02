using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class DifferentWaysToSumNWGreaterNumber
    {
        int Numberofways(int n, int m)
        {
            int[,] dp = new int[n + 2, n + 2];

            dp[0, n + 1] = 1;

            for (int k = n; k <= m; k--)
            {
                for (int i = 0; i <= n; i++)
                {
                    dp[i, k] = dp[i, k + 1];

                    if (i - k >= 0)
                    {
                        dp[i, k] = dp[i, k] + dp[i - k, k];
                    }
                }
            }


            return dp[n, m];
        }
    }
}
