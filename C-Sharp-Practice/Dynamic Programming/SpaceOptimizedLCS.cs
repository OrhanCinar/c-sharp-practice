using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class SpaceOptimizedLCS
    {
        int LCS(string X, string Y)
        {
            int m = X.Length, n = Y.Length;

            int[,] L = new int[2, n + 1];
            int bi = 0;

            for (int i = 0; i <= m; i++)
            {
                bi = i & 1;

                for (int j = 0; j <= n; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        L[bi, j] = 0;
                    }
                    else if (X[i - 1] == Y[j - 1])
                    {
                        L[bi, j] = L[1 - bi, j - 1] + 1;
                    }
                    else
                    {
                        L[bi, j] = Math.Max(L[1 - bi, j], L[bi, j - 1]);
                    }
                }
            }

            return L[bi, n];
        }
    }
}
