using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class MinCellReqToDestination
    {
        int MinCells(int[,] mat, int m, int n)
        {
            int[,] dp = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dp[i, j] = int.MaxValue;
                }
            }

            dp[0, 0] = 1;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (dp[i, j] != int.MaxValue && (j + mat[i, j] < n && (dp[i, j] + 1) < dp[i, j + mat[i, j]]))
                    {
                        dp[i, j + mat[i, j]] = dp[i, j] + 1;
                    }

                    if (dp[i, j] != int.MaxValue & (i + mat[i, j] < m && (dp[i, j] + 1) < dp[i + mat[i, j], j])){
                        dp[i + mat[i, j], j] = dp[i, j] + 1;
                    }
                }
            }

            if (dp[m - 1, n - 1] != int.MaxValue)
            {
                return dp[m - 1, n - 1];
            }

            return -1;
        }
    }
}
