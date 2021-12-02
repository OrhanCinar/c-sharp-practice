using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class CountPathsWMostKTurns
    {
        int MAX = 100;

        int[,,,] dp;

        public CountPathsWMostKTurns()
        {
            dp = new int[MAX, MAX, MAX, 2];
        }

        int CountPathsUtil(int i, int j, int k, int d)
        {
            if (i < 0 || j < 0)
            {
                return 0;
            }

            if (i == 0 && j == 0)
            {
                return 1;
            }

            if (k == 0)
            {
                if (d == 0 && i == 0)
                {
                    return 1;
                }

                if (d == 1 && j == 0)
                {
                    return 0;
                }
            }

            if (dp[i, j, k, d] != -1)
            {
                return dp[i, j, k, d];
            }

            if (d == 0)
            {
                return dp[i, j, k, d] = CountPathsUtil(i, j - 1, k, d) + CountPathsUtil(i - 1, j, k - 1, d == 1 ? 0 : 1);
            }

            return dp[i, j, k, d] = CountPathsUtil(i - 1, j, k, d) + CountPathsUtil(i, j - 1, k - 1, d == 1 ? 0 : 1);
        }
    }
}
