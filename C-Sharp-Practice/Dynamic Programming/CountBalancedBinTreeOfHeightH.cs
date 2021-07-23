using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class CountBalancedBinTreeOfHeightH
    {
        int MOD = 1000000007;
        long CountBT(int h)
        {
            long[] dp = new long[h + 1];

            dp[0] = 1;
            dp[1] = 1;

            for (int i = 2; i <= h; ++i)
            {
                dp[i] = (dp[i - 1] * ((2 * dp[i - 2]) % MOD + dp[i - 1]) % MOD) % MOD;
            }

            return dp[h];
        }
    }
}
