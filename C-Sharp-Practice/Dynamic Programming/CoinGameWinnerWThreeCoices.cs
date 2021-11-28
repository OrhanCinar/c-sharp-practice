using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class CoinGameWinnerWThreeCoices
    {
        bool FindWinner(int x, int y, int n)
        {
            bool[] dp = new bool[n + 1];

            for (int i = 0; i < n + 1; i++)
            {
                dp[i] = false;
            }

            dp[0] = false;
            dp[1] = true;

            for (int i = 2; i <= n; i++)
            {
                if (i - 1 >= 0 && dp[i - 1] == false)
                {
                    dp[i] = true;
                }
                else if (i - x >= 0 && dp[i - x] == false)
                {
                    dp[i] = true;
                }
                else if (i - y >= 0 && dp[i - y] == false)
                {
                    dp[i] = true;
                }
                else
                {
                    dp[i] = false;
                }
            }

            return dp[n];
        }
    }
}
