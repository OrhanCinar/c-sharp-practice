using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class CountArrayHavingConsecutiveElem
    {
        int Countarray(int n, int k, int x)
        {
            int[] dp = new int[109];
            dp[0] = 0;
            dp[1] = 1;

            for (int i = 0; i < n; i++)
            {
                dp[i] = (k - 2) * dp[i - 1] + (k - 1) * dp[i - 2];
            }

            return (x == 1 ? (k - 1) * dp[n - 2] : dp[n - 1]);
        }
    }
}
