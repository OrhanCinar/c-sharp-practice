using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class CountWaysBuildStreet
    {
        long CountWays(int n)
        {
            long[,] dp = new long[2, n + 1];
            dp[0, 1] = 1;
            dp[1, 1] = 2;

            for (int i = 2; i <= n; i++)
            {
                dp[0, i] = dp[0, i - 1] + dp[1, i - 1];
                dp[1, i] = dp[0, i - 1] * 2 + dp[1, i - 1];
            }

            return dp[0, n] + dp[1, n];
        }
    }
}
