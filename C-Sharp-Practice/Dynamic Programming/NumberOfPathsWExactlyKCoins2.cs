using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class NumberOfPathsWExactlyKCoins2
    {
        readonly int R = 3;
        readonly int C = 3;
        readonly int MAX_K = 100;

        int[,,] dp;

        public NumberOfPathsWExactlyKCoins2()
        {
            dp = new int[R, C, MAX_K];
        }

        int PathCountDPRecDP(int[,] mat, int m, int n, int k)
        {
            if (m < 0 || n < 0)
            {
                return 0;
            }

            if (m == 0 && n == 0)
            {
                return k == mat[m, n] ? 1 : 0;
            }

            if (dp[m, n, k] != -1)
            {
                return dp[m, n, k];
            }

            dp[m, n, k] = PathCountDPRecDP(mat, m - 1, n, k - mat[m, n]) + PathCountDPRecDP(mat, m, n - 1, k - mat[m, n]);

            return dp[m, n, k];
        }
    }
}
