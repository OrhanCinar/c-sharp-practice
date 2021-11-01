using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class CountDistinctSubsequences
    {
        int MAX_CHAR = 256;

        int CountSub(String str)
        {
            int[] last = new int[MAX_CHAR];

            for (int i = 0; i < MAX_CHAR; i++)
            {
                last[i] = -1;
            }

            int n = str.Length;

            int[] dp = new int[n + 1];

            dp[0] = 1;

            for (int i = 1; i <= n; i++)
            {
                dp[i] = 2 * dp[i - 1];

                if (last[(int)str[i - 1]] != -1)
                {
                    dp[i] = dp[i] - dp[last[(int)str[i - 1]]];
                }

                last[(int)str[i - 1]] = i - 1;
            }

            return dp[n];
        }
    }
}
