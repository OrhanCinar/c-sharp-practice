using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class FindMaxPossibleStolenValueHouse
    {
        int MaxLoot(int[] hval, int n)
        {
            if (n == 0)
            {
                return 0;
            }

            if (n == 1)
            {
                return hval[0];
            }

            if (n == 2)
            {
                return Math.Max(hval[0], hval[1]);
            }

            int[] dp = new int[n];


            dp[0] = hval[0];
            dp[1] = Math.Max(hval[0], hval[1]);


            for (int i = 2; i < n; i++)
            {
                dp[i] = Math.Max(hval[i] + dp[i - 2], dp[i - 1]);
            }

            return dp[n - 1];
        }
    }
}
