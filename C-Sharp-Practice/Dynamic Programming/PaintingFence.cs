using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    public class PaintingFence
    {
        public long Count(int n, int k)
        {
            long[] dp = new long[n + 1];

            Array.Fill(dp, 0);
            int mod = 1000000007;

            dp[1] = k;

            int same = 0, diff = k;

            for (int i = 2; i <= n; i++)
            {
                same = diff;

                diff = (int)(dp[i - 1] * (k - 1));

                diff = diff % mod;

                dp[i] = (same + diff) % mod;
            }


            return dp[n];
        }
    }
}
