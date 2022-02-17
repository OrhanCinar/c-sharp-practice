using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class MinNumSquareSumEqualsToN5
    {
        int NumSquares(int n)
        {
            List<int> arr = new List<int>();
            int k = 1;

            while (k * k <= n)
            {
                arr.Add(k * k);
                k++;
            }

            int[] dp = new int[n + 1];

            for (int i = 0; i < n + 1; i++)
            {
                dp[i] = int.MaxValue;
            }

            dp[n] = 0;

            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = 0; j < arr.Count; j++)
                {
                    if (i + arr[j] <= n)
                    {
                        dp[i] = Math.Min(dp[i], dp[i + arr[j]]);
                    }
                }

                dp[i]++;
            }

            return dp[0];
        }
    }
}
