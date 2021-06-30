using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class MinCostFillWeightBag2
    {
        int MinCost(int[] cost, int n)
        {
            int[] dp = new int[n + 1];
            dp[0] = 0;

            for (int i = 1; i <= n; i++)
            {
                int min_cost = int.MaxValue;

                for (int j = 0; j < i; j++)
                {
                    if (j < n && cost[j] != -1)
                    {
                        min_cost = Math.Min(min_cost, cost[j] + dp[i - j - 1]);
                    }
                }

                dp[i] = min_cost;
            }

            return dp[n];
        }
    }
}
