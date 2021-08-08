﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class CountFillN4Grid
    {
        int Count(int n)
        {
            int[] dp = new int[n + 1];
            dp[0] = 0;


            for (int i = 1; i < n; i++)
            {
                if (i >= 1 && i <= 3)
                {
                    dp[i] = 1;
                }
                else if (i == 4)
                {
                    dp[i] = 2;
                }
                else
                {
                    dp[i] = dp[i - 1] + dp[i - 4];
                }
            }

            return dp[n];
        }
    }
}
