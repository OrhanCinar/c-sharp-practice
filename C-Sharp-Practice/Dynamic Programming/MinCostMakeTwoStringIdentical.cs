﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class MinCostMakeTwoStringIdentical
    {
        int Lcs(String X, String Y, int m, int n)
        {
            int[,] L = new int[m + 1, n + 1];

            for (int i = 0; i <= m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        L[i, j] = 0;
                    }
                    else if (X[i - 1] == Y[j - 1])
                    {
                        L[i, j] = L[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        L[i, j] = Math.Max(L[i - 1, j], L[i, j - 1]);
                    }
                }
            }

            return L[m, n];
        }

        int FindMinCost(String X, String Y, int costX, int costY)
        {

            int m = X.Length;
            int n = Y.Length;
            int len_LCS;
            len_LCS = Lcs(X, Y, m, n);

            return costX * (m - len_LCS) + costY * (n - len_LCS);
        }
    }
}
