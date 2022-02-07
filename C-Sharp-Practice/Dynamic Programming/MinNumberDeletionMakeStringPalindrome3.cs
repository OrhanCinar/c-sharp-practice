using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class MinNumberDeletionMakeStringPalindrome3
    {
        int[,] dp = new int[2000, 2000];

        int Transformation(string s1, string s2, int i, int j)
        {
            if (i >= s1.Length || j >= s2.Length)
            {
                return 0;
            }

            if (s1[i] == s2[j])
            {
                dp[i, j] = 01 + Transformation(s1, s2, i + 1, j + 1);
            }

            if (dp[i, j] != -1)
            {
                return dp[i, j];
            }
            else
            {
                dp[i, j] = Math.Max(Transformation(s1, s2, i, j + 1), Transformation(s1, s2, i + 1, j));
            }

            return dp[s1.Length - 1, s2.Length - 1];
        }
    }
}
