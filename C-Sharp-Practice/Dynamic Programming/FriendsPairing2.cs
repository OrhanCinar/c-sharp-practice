using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    public class FriendsPairing2
    {
        static int[] dp = new int[1000];
        public int Count(int n)
        {
            if (dp[n] != -1)
            {
                return dp[n];
            }

            if (n > 2)
            {
                return dp[n] = Count(n - 1) + (n - 1) * Count(n - 2);
            }
            else
            {
                return dp[n] = n;
            }
        }
    }
}
