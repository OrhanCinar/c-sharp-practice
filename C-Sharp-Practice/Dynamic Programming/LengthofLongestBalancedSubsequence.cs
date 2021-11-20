using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class LengthofLongestBalancedSubsequence
    {
        int MaxLength(String s, int n)
        {
            int[,] dp = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                if (s[i] == '(' && s[i + 1] == ')')
                {
                    dp[i, i + 1] = 2;
                }
            }

            for (int l = 2; l < n; l++)
            {
                for (int i = l, j = l; j < n; i++, j++)
                {
                    if (s[i] == '(' && s[j] == ')')
                    {
                        dp[i, j] = 2 + dp[i + 1, j - 1];
                    }

                    for (int k = 1; k < j; k++)
                    {
                        dp[i, j] = Math.Max(dp[i, j], dp[i, k] + dp[k + 1, j]);
                    }
                }
            }

            return dp[0, n - 1];
        }
    }
}
