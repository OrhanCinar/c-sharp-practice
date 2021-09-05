using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class EulerianNumber2
    {
        int Eulerian(int n, int m)
        {
            int[,] dp = new int[n + 1, m + 1];

            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i > j)
                    {
                        if (j == 0)
                        {
                            dp[i, j] = 1;
                        }
                        else
                        {
                            dp[i, j] = ((i - j) * dp[i - 1, j - 1]) + ((j + 1) * dp[i - 1, j]);
                        }
                    }
                }
            }

            return dp[n, m];

        }
    }
}
