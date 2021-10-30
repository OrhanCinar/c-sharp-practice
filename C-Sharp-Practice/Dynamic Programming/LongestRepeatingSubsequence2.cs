using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class LongestRepeatingSubsequence2
    {
        int[,] dp = new int[1000, 1000];
        int FindLongestRepeatingSubSeq(char[] X, int m, int n)
        {
            if (dp[m, n] != -1)
            {
                return dp[m, n];
            }

            if (m == 0 || n == 0)
            {
                return dp[m, n] = 0;
            }

            if (X[m - 1] == X[n - 1] && m != n)
            {
                return dp[m, n] = FindLongestRepeatingSubSeq(X, m - 1, n - 1) + 1;
            }

            return dp[m, n] = Math.Max(FindLongestRepeatingSubSeq(X, m, n - 1), FindLongestRepeatingSubSeq(X, m - 1, n));
        }
    }
}
