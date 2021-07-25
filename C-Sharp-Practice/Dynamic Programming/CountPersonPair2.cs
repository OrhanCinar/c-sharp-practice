using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class CountPersonPair2
    {
        int NumberOfWays(int x)
        {
            int[] dp = new int[x + 1];
            dp[0] = dp[1] = 1;

            for (int i = 2; i <= x; i++)
            {
                dp[i] = dp[i - 1] + (i - 1) * dp[i - 2];
            }

            return dp[x];
        }
    }
}
