using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class Jacobsthal_Lucas_Numbers2
    {
        int Jacobsthal(int n)
        {
            int[] dp = new int[n + 1];

            dp[0] = 0;
            dp[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                dp[i] = dp[i - 1] + 2 * dp[i - 2];
            }

            return dp[n];
        }


        int Jacobsthal_Lucas(int n)
        {
            int[] dp = new int[n + 1];

            dp[0] = 2;
            dp[1] = 1;

            for (int i = 0; i <= n; i++)
            {
                dp[i] = dp[i - 1] + 2 * dp[i - 2];
            }

            return dp[n];
        }
    }
}
