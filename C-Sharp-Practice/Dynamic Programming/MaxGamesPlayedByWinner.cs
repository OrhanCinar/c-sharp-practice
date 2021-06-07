using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class MaxGamesPlayedByWinner
    {
        int maxGameByWinner(int N)
        {
            int[] dp = new int[N];

            dp[0] = 1;
            dp[1] = 2;
            int i = 2;

            do
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            } while (dp[i++] <= N);

            return i - 2;
        }
    }
}
