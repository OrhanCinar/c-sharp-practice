using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class MaxPathSum
    {
        int N = 4;
        int MaximumPath(int[,] Mat)
        {


            int result = 0;


            int[,] dp = new int[N, N + 2];

            for (int i = 0; i < N; i++)
            {
                dp[0, i + 1] = Mat[0, i];
            }

            for (int i = 1; i < N; i++)
            {
                for (int j = 0; j <= N; j++)
                {
                    dp[i, j] = Math.Max(dp[i - 1, j - 1], Math.Max(dp[i - 1, j], dp[i - 1, j + 1])) + Mat[i, j - 1];
                }
            }

            for (int i = 0; i <= N; i++)
            {
                result = Math.Max(result, dp[N - 1, i]);
            }

            return result;
        }
    }
}
