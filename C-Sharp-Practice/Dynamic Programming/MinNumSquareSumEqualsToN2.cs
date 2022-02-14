using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class MinNumSquareSumEqualsToN2
    {
        int GetMinSquares(int n)
        {
            if (n <= 3)
            {
                return n;
            }

            int[] dp = new int[n + 1];

            dp[0] = 0;
            dp[1] = 1;
            dp[2] = 2;
            dp[3] = 3;

            for (int i = 4; i <= n; i++)
            {
                dp[i] = 1;

                for (int x = 1; x < Math.Ceiling(Math.Sqrt(i)); x++)
                {
                    int temp = x * x;
                    if (temp > i)
                    {
                        break;
                    }
                    else
                    {
                        dp[i] = Math.Min(dp[i], 1 + dp[i - temp]);
                    }
                }
            }

            int res = dp[n];
            return res;
        }
    }
}
