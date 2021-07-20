using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class CountDiffWaysToExpressNSum
    {
        int CountWays(int n)
        {
            int[] Dp = new int[n + 1];
            Dp[0] = Dp[1] = Dp[2] = 1;
            Dp[3] = 2;

            for (int i = 4; i <= n; i++)
            {
                Dp[i] = Dp[i - 1] + Dp[i - 3] + Dp[i - 4];
            }

            return Dp[n];
        }
    }
}
