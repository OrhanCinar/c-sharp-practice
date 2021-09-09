using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class EntringerNumber2
    {
        int Zigzag(int n, int k)
        {
            int[,] dp = new int[n + 1, k + 1];

            dp[0, 0] = 1;

            for (int i = 0; i <= n; i++)
            {
                dp[i, 0] = 0;
            }

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j < Math.Min(i, k); j++)
                {
                    dp[i, j] = dp[i, j - 1] + dp[i - 1, i - j];
                }
            }

            return dp[n, k];
        }
    }
}
