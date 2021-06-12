using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class MaxSumPairSpecificDiff
    {
        int maxSumPairWithDifferenceLessThanK(int[] arr, int N, int K)
        {
            Array.Sort(arr);

            int[] dp = new int[N];
            dp[0] = 0;

            for (int i = 1; i < N; i++)
            {
                dp[i] = dp[i - 1];

                if (arr[i] - arr[i - 1] < K)
                {
                    if (i >= 2)
                    {
                        dp[i] = Math.Max(dp[i], dp[i - 2] + arr[i] + arr[i - 1]);
                    }
                    else
                    {
                        dp[i] = Math.Max(dp[i], arr[i] + arr[i - 1]);
                    }
                }
            }

            return dp[N - 1];
        }
    }
}
