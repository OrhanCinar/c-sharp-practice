using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class RecursiveBreakNumber3MaxSum2
    {
        int BreakSum(int n)
        {
            int[] dp = new int[n + 1];
            dp[0] = 0;
            dp[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                dp[i] = Math.Max(dp[i / 2] + dp[i / 3] + dp[i / 4], i);
            }

            return dp[n];
        }
    }
}
