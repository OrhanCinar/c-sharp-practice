using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    public class FriendsPairing
    {
        public int Count(int n)
        {
            int[] dp = new int[n + 1];
            for (int i = 0; i < n; i++)
            {
                if (i <= 2)
                {
                    dp[i] = i;
                }
                else
                {
                    dp[i] = dp[i - 1] + (i - 1) * dp[i - 2];
                }
            }

            return dp[n];
        }
    }
}
