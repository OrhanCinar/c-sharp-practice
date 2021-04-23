using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    public class LargestDivisiblePairs
    {
        public int LargestSubset(int[] a, int n)
        {
            int[] dp = new int[n];

            dp[n - 1] = 1;

            for (int i = n - 2; i >= 0; i--)
            {
                int max = 0;

                for (int j = i + 1; j < n; j++)
                {
                    if (a[j] % a[i] == 0 | a[i] % a[j] == 0)
                    {
                        max = Math.Max(max, dp[j]);
                    }

                    dp[i] = 1 + max;
                }
            }

            return dp.Max();
        }
    }
}
