using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class CountAllPalindromicSubsequence2
    {
        int n;
        int[,] dp = new int[1000, 1000];

        string str = "abcb";

        int CountPS(int i, int j)
        {
            if (i > j)
            {
                return 0;
            }

            if (dp[i, j] != -1)
            {
                return dp[i, j];
            }

            if (i == j)
            {
                return dp[i, j] = 1;
            }
            else if (str[i] == str[j])
            {
                return dp[i, j] = CountPS(i + 2, j) + CountPS(i, j - 1) + 1;
            }
            else
            {
                return dp[i, j] = CountPS(i + 1, j) + CountPS(i, j - 1) - CountPS(i + 1, j - 1);
            }
        }
    }
}
