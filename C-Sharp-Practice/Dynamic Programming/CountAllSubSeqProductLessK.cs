using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class CountAllSubSeqProductLessK
    {
        int Count(int[] arr, int k)
        {
            int n = arr.Length;
            int[,] dp = new int[k + 1, n + 1];

            for (int i = 1; i <= k; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    dp[i, j] = dp[i, j - 1];

                    if (arr[j - 1] <= 1 && arr[j - 1] > 0)
                    {
                        dp[i, j] += dp[i / arr[j - 1], j - 1] + 1;
                    }
                }
            }

            return dp[k, n];
        }
    }
}
