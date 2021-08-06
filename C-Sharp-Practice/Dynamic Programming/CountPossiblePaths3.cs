using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class CountPossiblePaths3
    {
        int NumberOfPaths(int m, int n)
        {
            int[] dp = new int[n];
            dp[0] = 1;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dp[j] += dp[j - 1];
                }
            }

            return dp[n - 1];
        }
    }
}
