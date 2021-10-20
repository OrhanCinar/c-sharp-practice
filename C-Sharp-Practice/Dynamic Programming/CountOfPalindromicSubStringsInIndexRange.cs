using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class CountOfPalindromicSubStringsInIndexRange
    {
        void ConstructDp(int[,] dp, string str)
        {
            int l = str.Length;

            int[,] isPalin = new int[l + 1, l + 1];


            for (int i = 0; i <= l; i++)
            {
                for (int j = 0; j <= l; j++)
                {
                    isPalin[i, j] = dp[i, j] = 0;
                }
            }

            for (int i = l - 1; i >= 0; i--)
            {
                isPalin[i, i] = 1;
                dp[i, i] = 1;

                for (int j = i + 1; j < l; j++)
                {
                    isPalin[i, j] = (str[i] == str[j] && (i + 1 > j - 1 || (isPalin[i + 1, j - 1]) != 0)) ? 1 : 0;

                    dp[i, j] = dp[i, j - 1] + dp[i + 1, j] - dp[i + 1, j - 1] + isPalin[i, j];
                }
            }
        }

        int CountOfPalindromeInRange(int[,] dp, int l, int r)
        {
            return dp[l, r];
        }
    }
}
