﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    public class EditDistance2
    {
        int Min(int x, int y, int z)
        {
            if (x <= y && x <= z)
            {
                return x;
            }

            if (y <= x && y <= z)
            {
                return y;
            }

            return z;
        }

        public int EditDistDp(string s1, string s2, int m, int n)
        {
            int[,] dp = new int[m + 1, n + 1];

            for (int i = 0; i <= m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    if (i == 0)
                    {
                        dp[i, j] = j;
                    }
                    else if (j == 0)
                    {
                        dp[i, j] = i;
                    }
                    else if (s1[i - 1] == s2[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1];
                    }
                    else
                    {
                        dp[i, j] = 1 + Min(dp[i, j - 1], dp[i - 1, j], dp[i - 1, j - 1]);
                    }
                }
            }

            return dp[m, n];
        }
    }
}
