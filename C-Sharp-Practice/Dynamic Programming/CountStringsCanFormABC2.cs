using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class CountStringsCanFormABC2
    {
        int CountStrUtil(int[,,] dp, int n, int bCount = 1, int cCount = 2)
        {
            if (bCount < 0 || cCount < 0)
            {
                return 0;
            }

            if (n == 0)
            {
                return 1;
            }

            if (bCount == 0 && cCount == 0)
            {
                return 1;
            }

            if (dp[n, bCount, cCount] != -1)
            {
                return dp[n, bCount, cCount];
            }

            int res = CountStrUtil(dp, n - 1, bCount, cCount);
            res += CountStrUtil(dp, n - 2, bCount - 1, cCount);
            res += CountStrUtil(dp, n - 1, bCount, cCount - 1);

            return dp[n, bCount, cCount] = res;

        }
    }
}
