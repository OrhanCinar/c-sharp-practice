using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class FindMaxSumArrayLessOrEqualM
    {
        int N = 105;
        int M = 1001;

        int INF = -1111111111;

        int MaxSum(int[][] arr)
        {
            int[,] dp = new int[N, M];
            int[] current_arr = new int[M];
            int[] maxsum = new int[M];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    dp[i, j] = -1;
                }
            }

            current_arr[0] = 0;
            dp[0, 0] = 0;

            for (int i = 1; i <= 5; i++)
            {
                int len = arr[i - 1][0];

                for (int j = 0; j <= len; j++)
                {
                    current_arr[j] = arr[i - 1][j];
                    current_arr[j] += current_arr[j - 1];
                    maxsum[j] = INF;
                }

                for (int j = 1; j <= len && j <= 6; j++)
                {
                    for (int k = 0; k <= len; k++)
                    {
                        if (j + k - 1 <= len)
                        {
                            maxsum[j] = Math.Max(maxsum[j], current_arr[j + k - 1] - current_arr[k - 1]);
                        }
                    }
                }

                for (int j = 0; j <= 6; j++)
                {
                    dp[i, j] = dp[i - 1, j];
                }

                for (int j = 1; j <= 6; j++)
                {
                    for (int cur = 1; cur <= j && cur <= len; cur++)
                    {
                        dp[i, j] = Math.Max(dp[i, j], dp[i - 1, j - cur] + maxsum[cur]);
                    }
                }
            }

            int ans = 0;

            for (int i = 0; i <= 6; i++)
            {
                ans = Math.Max(ans, dp[5, i]);
            }

            return ans;
        }
    }
}
