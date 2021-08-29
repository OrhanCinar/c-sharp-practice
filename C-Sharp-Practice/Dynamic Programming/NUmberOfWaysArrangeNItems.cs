using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class NUmberOfWaysArrangeNItems
    {
        int WaysToArrange(int N, int K, int[] k)
        {
            int[,] C = new int[N + 1, N + 1];
            int i, j;


            for (i = 0; i <= N; i++)
            {
                for (j = 0; j <= i; j++)
                {
                    if (j == 0 || j == 1)
                    {
                        C[i, j] = 1;
                    }
                    else
                    {
                        C[i, j] = (C[i - 1, j - 1] + C[i - 1, j]);
                    }
                }
            }
            int[] dp = new int[K + 1];

            int count = 0;

            dp[0] = 1;

            for (i = 0; i < K; i++)
            {
                dp[i + 1] = (dp[i] * C[count + k[i] - 1, k[i] - 1]);
                count += k[i];
            }

            return dp[K];
        }
    }
}
