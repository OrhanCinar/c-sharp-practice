using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class MinStepDeleteStrAfterRepeated
    {
        int MinStepToDeleteString(string str)
        {
            int N = str.Length;

            int[,] dp = new int[N + 1, N + 1];

            for (int i = 0; i <= N; i++)
            {
                for (int j = 0; j <= N; j++)
                {
                    dp[i, j] = 0;
                }
            }

            for (int len = 0; len <= N; len++)
            {
                for (int i = 0, j = len - 1; i < N; i++, j++)
                {
                    if (len == 1)
                    {
                        dp[i, j] = 1;
                    }
                    else
                    {
                        dp[i, j] = 1 + dp[i + 1, j];

                        if (str[i] == str[i + 1])
                        {
                            dp[i, j] = Math.Min(1 + dp[i + 2, j], dp[i, j]);
                        }

                        for (int k = i + 1; k <= j; k++)
                        {
                            if (str[i] == str[k])
                            {
                                dp[i, j] = Math.Min(dp[i + 1, k - 1] + dp[k + 1, j], dp[i, j]);
                            }
                        }
                    }
                }
            }

            return dp[0, N - 1];
        }
    }
}
