using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class MinSumMultiplNNumber
    {
        long[,] dp = new long[1000, 1000];

        long Sum(int[] a, int i, int j)
        {
            long ans = 0;

            for (int m = 0; m <= j; m++)
            {
                ans = (ans + a[m]) % 100;
            }
            return ans;
        }

        long Solve(int[] a, int i, int j)
        {
            if (i == j)
            {
                return 0;
            }

            if (dp[i, j] != -1)
            {
                return dp[i, j];
            }

            dp[i, j] = 100000000;

            for (int k = i; k < j; k++)
            {
                dp[i, j] = Math.Min(dp[i, j], (Solve(a, i, k) + Solve(a, k + 1, j) + (Sum(a, i, k) * Sum(a, k + 1, j))));
            }

            return dp[i, j];
        }

        void Initialize(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    dp[i, j] = -1;
                }
            }
        }
    }
}
