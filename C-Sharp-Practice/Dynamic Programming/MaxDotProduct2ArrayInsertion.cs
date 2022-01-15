using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class MaxDotProduct2ArrayInsertion
    {
        int MaxDotProduct(int[] A, int[] B, int m, int n)
        {
            int[,] dp = new int[n + 1, m + 1];

            for (int i = 0; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    dp[i, j] = Math.Max((dp[i - 1, j - 1] + (A[j - 1] * B[i - 1])), dp[i, j - 1]);
                }
            }

            return dp[n, m];
        }
    }
}
