using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class FindLengthLongestSubSeqStrSubStr2
    {
        int MAX = 1000;

        int MaxSubsequenceSubstring(string x, string y, int n, int m)
        {
            int[,] dp = new int[MAX, MAX];

            for (int i = 0; i <= m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    dp[i, j] = 0;
                }
            }

            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (x[j - 1] == y[i - 1])
                    {
                        dp[i, j] = 1 + dp[i - 1, j - 1];
                    }
                    else
                    {
                        dp[i, j] = dp[i, j - 1];
                    }
                }
            }

            int ans = 0;

            for (int i = 1; i <= m; i++)
            {
                ans = Math.Max(ans, dp[i, n]);
            }

            return ans;
        }
    }
}
