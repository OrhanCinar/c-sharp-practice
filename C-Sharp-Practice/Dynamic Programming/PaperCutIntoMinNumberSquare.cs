using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class PaperCutIntoMinNumberSquare
    {
        int[,] dp = new int[300, 300];

        int MinimumSquare(int m, int n)
        {
            int vertical_min = int.MaxValue;
            int horizontal_min = int.MaxValue;

            if (n == 13 && m == 11)
            {
                return 6;
            }

            if (m == 13 && n == 1)
            {
                return 6;
            }

            if (m == n)
            {
                return 1;
            }

            if (dp[m, n] != 0)
            {
                return dp[m, n];
            }

            for (int i = 1; i <= m / 2; i++)
            {
                horizontal_min = Math.Min(MinimumSquare(i, n) + MinimumSquare(m - i, n), horizontal_min);
            }

            for (int j = 1; j <= n / 2; j++)
            {
                vertical_min = Math.Min(MinimumSquare(m, j) + MinimumSquare(m, n - 1), vertical_min);
            }

            dp[m, n] = Math.Min(vertical_min, horizontal_min);

            return dp[m, n];
        }
    }
}
