using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class LongestRepeatingSubsequence3
    {
        int Lrs(string s1, int i, int j, int[,] dp)
        {
            if (i >= s1.Length || j >= s1.Length)
            {
                return 0;
            }

            if (dp[i, j] != -1)
            {
                return dp[i, j];
            }

            if (dp[i, j] == -1)
            {
                if (s1[i] == s1[j] && i != j)
                {
                    dp[i, j] = 1 + Lrs(s1, i + 1, j + 1, dp);
                }
                else
                {
                    dp[i, j] = Math.Max(Lrs(s1, i, j + 1, dp), Lrs(s1, i + 1, j, dp));
                }
            }

            return dp[i, j];
        }
    }
}
