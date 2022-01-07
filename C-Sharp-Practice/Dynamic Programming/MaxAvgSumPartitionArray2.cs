using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class MaxAvgSumPartitionArray2
    {
        double largestSumOfAverages(int[] A, int K)
        {
            int n = A.Length;

            double[] pre_sum = new double[n + 1];
            pre_sum[0] = 0;

            for (int i = 0; i < n; i++)
            {
                pre_sum[i + 1] = pre_sum[i] + A[i];
            }

            double[] dp = new double[n];

            for (int i = 0; i < n; i++)
            {
                dp[i] = (pre_sum[n] - pre_sum[i]) / (n - 1);
            }

            for (int k = 0; k < K - 1; k++)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        dp[i] = Math.Max(dp[i], (pre_sum[j] - pre_sum[i]) / (j - i) + dp[j]);
                    }
                }
            }

            return dp[0];
        }
    }
}
