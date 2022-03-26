using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class CheckPossibleCrossMatrix
    {
        int N = 105;

        int MaximumValue(int n, int m, int p, int[,] grid)
        {
            bool[,,] dp = new bool[N, N, N];
            int i, j, k;

            for (i = 0; i < N; i++)
            {
                for (j = 0; j < N; j++)
                {
                    for (k = 0; k < N; k++)
                    {
                        dp[i, j, k] = false;
                    }
                }
            }

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    for (k = grid[i, j]; k <= p; k++)
                    {
                        if (i == 0 && j == 0)
                        {
                            if (k == grid[i, j])
                            {
                                dp[i, j, k] = true;
                            }
                        }
                        else if (i == 0)
                        {
                            dp[i, j, k] = dp[i, j, k] || dp[i - 1, j, k - grid[i, j]];
                        }
                        else
                        {
                            dp[i, j, k] = dp[i, j, k] || dp[i, j - 1, k - grid[i, j]];


                            dp[i, j, k] = dp[i, j, k] || dp[i - 1, j, k - grid[i, j]];

                            dp[i, j, k] = dp[i, j, k] || dp[i - 1, j - 1, k - grid[i, j]];
                        }
                    }
                }
            }

            k = p;

            int ans = 0;

            for (ans = k; ans >= 0; ans--)
            {
                if (dp[n - 1, m - 1, ans])
                {
                    break;
                }
            }

            return ans;
        }
    }
}
