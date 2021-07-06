using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class LongestCommonSubstring2
    {
        int LCSubStr(string s, string t, int n, int m)
        {
            int[,] dp = new int[2, m + 1];
            int res = 0;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    if (s[i - 1] == t[j - 1])
                    {
                        dp[i % 2, j] = dp[(i - 1) % 2, j - 1] + 1;

                        if (dp[i % 2, j] > res)
                        {
                            res = dp[i % 2, j];
                        }
                    }
                    else
                    {
                        dp[i % 2, j] = 0;
                    }
                }
            }

            return res;
        }
    }
}
