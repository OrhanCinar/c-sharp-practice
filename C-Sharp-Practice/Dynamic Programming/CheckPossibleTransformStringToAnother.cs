using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class CheckPossibleTransformStringToAnother
    {
        bool Check(string s1, string s2)
        {
            int n = s1.Length;
            int m = s2.Length;

            bool[,] dp = new bool[n + 1, m + 1];

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= m; j++)
                {
                    dp[i, j] = false;
                }
            }

            dp[0, 0] = true;

            for (int i = 0; i < s1.Length; i++)
            {
                for (int j = 0; j <= s2.Length; j++)
                {
                    if (dp[i, j])
                    {
                        if (j < s2.Length && Char.ToUpper(s1[i]) == s2[j])
                        {
                            dp[i + 1, j + 1] = true;
                        }

                        if (!Char.IsUpper(s1[i]))
                        {
                            dp[i + 1, j] = true;
                        }
                    }
                }
            }

            return dp[n, m];
        }
    }
}
