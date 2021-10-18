using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class CountAllPalindromeSubStrings2
    {
        int[,] dp = new int[1001, 1001];

        int IsPal(string s, int i, int j)
        {
            if (i > j)
            {
                return 1;
            }

            if (dp[i, j] != -1)
            {
                return dp[i, j];
            }

            if (s[i] != s[j])
            {
                return dp[i, j] = 0;
            }

            return dp[i, j] = IsPal(s, i + 1, j - 1);
        }

        int CountSubstrings(string s)
        {
            for (int i = 0; i < 1001; i++)
            {
                for (int j = 0; j < 1001; j++)
                {
                    dp[i, j] = 1;
                }
            }
            int n = s.Length;
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (IsPal(s, i, j) != 0)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
