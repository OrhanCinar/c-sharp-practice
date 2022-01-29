using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class MinInitialPointsReachDestination
    {
        int MinInitialPoints(int[,] points, int R, int C)
        {
            int[,] dp = new int[R, C];
            int m = R, n = C;

            dp[m - 1, n - 1] = points[m - 1, n - 1] > 0 ? 1 : Math.Abs(points[m - 1, n - 1]) + 1;

            for (int i = m - 2; i >= 0; i--)
            {
                dp[i, n - 1] = Math.Max(dp[i + 1, n - 1] - points[i, n - 1], 1);
            }

            for (int j = n - 2; j >= 0; j--)
            {
                dp[m - 1, j] = Math.Max(dp[m - 1, j + 1] + points[m - 1, j], 1);
            }

            for (int i = m - 2; i >= 0; i--)
            {
                for (int j = n - 2; j >= 0; j--)
                {
                    int min_points_on_exit = Math.Min(dp[i + 1, j], dp[i, j + 1]);
                    dp[i, j] = Math.Max(min_points_on_exit - points[i, j], 1);
                }
            }

            return dp[0, 0];
        }
    }
}
