using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class LongestRepeatedSubSequence2
    {
        public string LongestRepeatedSubSequence(string str)
        {
            int n = str.Length, i, j;

            int[,] dp = new int[n + 1, n + 1];

            for (i = 0; i <= n; i++)
            {
                for (j = 0; j <= n; j++)
                {
                    dp[i, j] = 0;
                }
            }

            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= n; j++)
                {
                    if (str[i - 1] == str[j - 1] && i != j)
                    {
                        dp[i, j] = 1 + dp[i - 1, j - 1];
                    }
                    else
                    {
                        dp[i, j] = Math.Max(dp[i, j - 1], dp[i - 1, j]);
                    }
                }
            }

            string res = "";

            i = n;
            j = n;

            while (i > 0 && j > 0)
            {
                if (dp[i, j] == dp[i - 1, j - 1] + 1)
                {
                    res = res + str[i - 1];
                    i--;
                    j--;
                }
                else if (dp[i, j] == dp[i - 1, j])
                {
                    i--;
                }
                else
                {
                    j--;
                }
            }


            string reverse = "";

            for (int k = res.Length - 1; k >= 0; k--)
            {
                reverse = reverse + res[k];
            }
            return res;
        }
    }
}
