using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class ClusterArraySumSquare2
    {
        int inf = 1000000000;

        int MinCost(int[] a, int n, int k)
        {
            int[,] dp = new int[n + 1, k + 1];

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= k; j++)
                {
                    dp[i, j] = inf;
                }
            }

            dp[0, 0] = 0;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j <= k; j++)
                {
                    for (int m = i - 1; m >= 0; m--)
                    {
                        dp[i, j] = Math.Min(dp[i, j], dp[m, j - 1] + (a[i - 1] - a[m]) * (a[i - 1] - a[m]));
                    }
                }
            }

            return dp[n, k];
        }
    }
}
