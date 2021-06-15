using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class MaxNumberOfSegments
    {
        int MaximumSegments(int n, int a, int b, int c)
        {
            int[] dp = new int[n + 10];

            for (int i = 0; i < n + 10; i++)
            {
                dp[i] = -1;
            }

            dp[0] = 0;

            for (int i = 0; i < n; i++)
            {
                if (dp[i] != -1)
                {
                    if (i + a <= n)
                    {
                        dp[i + a] = Math.Max(dp[i] + 1, dp[i + a]);
                    }

                    if (i + b <= n)
                    {
                        dp[i + b] = Math.Max(dp[i] + 1, dp[i + b]);
                    }

                    if (i + c <= n)
                    {
                        dp[i + c] = Math.Max(dp[i] + 1, dp[i + c]);
                    }
                }
            }

            return dp[n];
        }
    }
}
