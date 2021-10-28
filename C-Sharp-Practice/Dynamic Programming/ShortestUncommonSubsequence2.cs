using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class ShortestUncommonSubsequence2
    {
        int MAX = 1005;

        int ShortestSeq(char[] S, char[] T)
        {
            int m = S.Length, n = T.Length;

            int[,] dp = new int[m + 1, n + 1];

            for (int i = 0; i < m; i++)
            {
                dp[i, 0] = 1;
            }

            for (int i = 0; i < n; i++)
            {
                dp[0, i] = MAX;
            }

            for (int i = 1; i <= m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    char ch = S[i - 1];
                    int k;

                    for (k = j - 1; k >= 0; k--)
                    {
                        if (T[k] == ch)
                        {
                            break;
                        }
                    }

                    if (k == -1)
                    {
                        dp[i, j] = 1;
                    }
                    else
                    {
                        dp[i, j] = Math.Min(dp[i - 1, j], dp[i - 1, k] + 1);
                    }
                }
            }

            int ans = dp[m, n];

            if (ans >= MAX)
            {
                ans = -1;
            }

            return ans;
        }
    }
}
