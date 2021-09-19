using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class UnboundedKnapsack
    {
        int GetUnboundedKnapsack(int W, int n, int[] val, int[] wt)
        {
            int[] dp = new int[W + 1];

            for (int i = 0; i < W; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (wt[j] <= i)
                    {
                        dp[i] = Math.Max(dp[i], dp[i - wt[j]] + val[j]);
                    }
                }
            }

            return dp[W];
        }
    }
}
