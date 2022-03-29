using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class GivenLargeNumberCheckSuSeqDivBy82
    {
        bool IsSubSeqDivisible(String str)
        {
            int n = str.Length;
            int[,] dp = new int[n + 1, 10];

            int[] arr = new int[n + 1];

            for (int i = 1; i <= n; i++)
            {
                arr[i] = (int)(str[i - 1] - '0');
            }

            for (int i = 1; i <= n; i++)
            {
                dp[i, arr[i] % 8] = 1;

                for (int j = 0; j < 8; j++)
                {
                    if (dp[i - 1, j] > dp[i, (j * 10 + arr[i]) % 8])
                    {
                        dp[i, (j * 10 + arr[i]) % 8] = dp[i - 1, j];
                    }

                    if (dp[i - 1, j] > dp[i, j])
                    {
                        dp[i, j] = dp[i - 1, j];
                    }
                }
            }

            for (int i = 1; i <= n; i++)
            {
                if (dp[i, 0] == 1)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
