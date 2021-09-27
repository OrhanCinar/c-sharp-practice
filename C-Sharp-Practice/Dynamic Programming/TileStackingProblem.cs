using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class TileStackingProblem
    {
        int N = 100;

        int PossibleWays(int n, int m, int k)
        {
            int[,] dp = new int[N, N];
            int[,] presum = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    dp[i, j] = 0;
                    presum[i, j] = 0;
                }
            }

            for (int i = 0; i < n + 1; i++)
            {
                dp[0, i] = 0;
                presum[0, i] = 1;
            }


            for (int i = 0; i < m + 1; i++)
            {
                presum[i, 0] = dp[i, 0] = 1;
            }

            for (int i = 1; i < m + 1; i++)
            {
                for (int j = 1; j < n + 1; j++)
                {
                    dp[i, j] = presum[i - 1, j];

                    if (j > k)
                    {
                        dp[i, j] -= presum[i - 1, j - k - 1];
                    }
                }

                for (int j = 0; j < n + 1; j++)
                {
                    presum[i, j] = dp[i, j] + presum[i, j - 1];
                }
            }

            return dp[m, n];
        }
    }
}
