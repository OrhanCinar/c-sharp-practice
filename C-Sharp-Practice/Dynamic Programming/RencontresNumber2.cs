using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class RencontresNumber2
    {
        int MAX = 100;

        void binomialCoeff(int[,] C, int n, int k)
        {
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= Math.Min(i, k); j++)
                {
                    if (j == 0 || j == i)
                    {
                        C[i, j] = 1;
                    }
                    else
                    {
                        C[i, j] = C[i - 1, j - 1] + C[i - 1, j];
                    }
                }
            }
        }

        int RencontresNumber(int[,] C, int n, int m)
        {
            int[,] dp = new int[n + 1, m + 1];

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= m; j++)
                {
                    if (j <= i)
                    {
                        if (i == 0 && j == 0)
                        {
                            dp[i, j] = 1;
                        }
                        else if (i == 1 && j == 0)
                        {
                            dp[i, j] = 0;
                        }
                        else if (j == 0)
                        {
                            dp[i, j] = (i - 1) * (dp[i - 1, 0] + dp[i - 2, 0]);
                        }
                        else
                        {
                            dp[i, j] = C[i, j] * dp[i - 1, 0];
                        }
                    }
                }
            }

            return dp[n, m];
        }
    }
}
