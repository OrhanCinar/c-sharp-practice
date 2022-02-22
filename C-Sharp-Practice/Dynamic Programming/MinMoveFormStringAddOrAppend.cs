using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class MinMoveFormStringAddOrAppend
    {
        int MinimalSteps(String s, int n)
        {
            int[] dp = new int[n];

            for (int i = 0; i < n; i++)
            {
                dp[i] = int.MaxValue;
            }

            string s1 = "", s2 = "";

            dp[0] = 1;

            s1 += s[0];

            for (int i = 1; i < n; i++)
            {
                s1 += s[i];

                s2 = s.Substring(i, 1);

                dp[i] = Math.Min(dp[i], dp[i - 1] + 1);

                if (s1 == s2)
                {
                    dp[i * 2 + 1] = Math.Min(dp[i] + 1, dp[i * 2 + 1]);
                }
            }

            return dp[n - 1];
        }
    }
}
