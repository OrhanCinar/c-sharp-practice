﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class MaxWeightPathEnding
    {
        int MaxCost(int[,] mat, int N)
        {
            int[,] dp = new int[N, N];
            dp[0, 0] = mat[0, 0];

            for (int i = 1; i < N; i++)
            {
                dp[i, 0] = mat[i, 0] + dp[i - 1, 0];
            }

            for (int i = 1; i < N; i++)
            {
                for (int j = 1; j < i + 1 && j < N; j++)
                {
                    dp[i, j] = mat[i, j] + Math.Max(dp[i - 1, j - 1], dp[i - 1, j]);
                }
            }

            int result = 0;

            for (int i = 0; i < N; i++)
            {
                if (result < dp[N - 1, i])
                {
                    result = dp[N - 1, i];
                }
            }

            return result;
        }
    }
}
