using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class FindMinAdjCost
    {
        int M = 100;

        int MinAdjustmentCost(int[] A, int n, int target)
        {
            int[,] dp = new int[n, M + 1];

            for (int j = 0; j <= M; j++)
            {
                dp[0, j] = Math.Abs(j - A[0]);
            }

            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j <= M; j++)
                {
                    dp[i, j] = int.MaxValue;

                    int k = Math.Max(j - target, 0);

                    for (; k <= Math.Min(M, j + target); k++)
                    {
                        dp[i, j] = Math.Min(dp[i, j], dp[i - 1, k] + Math.Abs(A[i] - j));
                    }
                }
            }

            int res = int.MaxValue;

            for (int j = 0; j <= M; j++)
            {
                res = Math.Min(res, dp[n - 1, j]);
            }

            return res;
        }
    }
}
