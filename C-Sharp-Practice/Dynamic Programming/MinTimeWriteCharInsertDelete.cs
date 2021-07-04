using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class MinTimeWriteCharInsertDelete
    {
        int MinTimeForWritingChars(int N, int insert, int remove, int copy)
        {

            if (N == 0)
            {
                return 0;
            }

            if (N == 1)
            {
                return insert;
            }

            int[] dp = new int[N + 1];

            for (int i = 0; i < N + 1; i++)
            {
                dp[i] = 0;
            }

            dp[1] = insert;


            for (int i = 2; i <= N; i++)
            {
                if (i % 2 == 0)
                {
                    dp[i] = Math.Min(dp[i - 1] + insert, dp[i / 2] + copy);
                }
                else
                {
                    dp[i] = Math.Min(dp[i - 1] + insert, dp[(i + 1) / 2] + copy + remove);
                }
            }

            return dp[N];
        }
    }
}
