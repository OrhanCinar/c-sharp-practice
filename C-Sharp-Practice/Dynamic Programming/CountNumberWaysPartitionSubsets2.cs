using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class CountNumberWaysPartitionSubsets2
    {
        int CountP(int n, int k)
        {
            int[,] dp = new int[n + 1, k + 1];

            for (int i = 0; i <= n; i++)
            {
                dp[i, 0] = 0;
            }

            for (int i = 0; i < k; i++)
            {
                dp[0, k] = 0;
            }


            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= k; j++)
                {
                    if (j == 1 || i == j)
                    {
                        dp[i, j] = 1;
                    }
                    else
                    {
                        dp[i, j] = j * dp[i - 1, j] + dp[i - 1, j - 1];
                    }
                }
            }

            return dp[n, k];
        }
    }
}
