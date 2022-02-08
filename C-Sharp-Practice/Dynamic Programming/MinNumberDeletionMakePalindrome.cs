using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class MinNumberDeletionMakePalindrome
    {
        int GetLevenstein(String input)
        {
            string revInput = Reverse(input);
            int n = input.Length;
            int[,] dp = new int[n + 1, n + 1];

            for (int i = 0; i <= n; ++i)
            {
                dp[0, i] = i;
                dp[i, 0] = i;
            }

            for (int i = 1; i <= n; ++i)
            {
                for (int j = 1; j <= n; ++j)
                {
                    if (input[i - 1] == revInput[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1];
                    }
                    else
                    {
                        dp[i, j] = 1 + Math.Min(dp[i - 1, j], dp[i, j - 1]);
                    }
                }
            }

            int res = int.MaxValue;

            for (int i = n, j = 0; i >= 0; i--, j++)
            {
                res = Math.Min(res, dp[i, j]);

                if (i < n)
                {
                    res = Math.Min(res, dp[i + 1, j]);
                }

                if (i > 0)
                {
                    res = Math.Min(res, dp[i - 1, j]);
                }
            }

            return res;
        }

        private string Reverse(string input)
        {
            char[] a = input.ToCharArray();
            int l, r = a.Length - 1;

            for (l = 0; l < r; l++, r--)
            {
                char temp = a[l];
                a[l] = a[r];
                a[r] = temp;
            }

            return String.Join("", a);
        }
    }
}
