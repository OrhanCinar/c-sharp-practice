using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class FindStringIsPalidrome2
    {
        int IsKPalDP(string str1, string str2, int m, int n)
        {
            int[,] dp = new int[m + 1, n + 1];

            for (int i = 0; i <= m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    if (i == 0)
                    {
                        dp[i, j] = j;
                    }
                    else if (j == 0)
                    {
                        dp[i, j] = i;
                    }
                    else if (str1[i - 1] == str2[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1];
                    }
                    else
                    {
                        dp[i, j] = 1 + Math.Max(dp[i - 1, j], dp[i, j - 1]);
                    }
                }
            }

            return dp[m, n];
        }

        bool IsKPal(string str, int k)
        {
            string revStr = str;
            revStr = Reverse(revStr);
            int len = str.Length;
            return (IsKPalDP(str, revStr, len, len) <= k * 2);
        }

        string Reverse(string str)
        {
            char[] sb = str.ToCharArray();
            Array.Reverse(sb);
            return new string(sb);
        }
    }
}
