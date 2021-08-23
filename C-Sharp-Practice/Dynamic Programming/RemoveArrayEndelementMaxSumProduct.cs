using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class RemoveArrayEndelementMaxSumProduct
    {
        int MAX = 50;

        int Solve(int[,] dp, int[] a, int low, int high, int turn)
        {
            if (low == high)
            {
                return a[low] * turn;
            }

            if (dp[low, high] != 0)
            {
                return dp[low, high];
            }

            dp[low, high] = Math.Max(a[low] * turn + Solve(dp, a, low + 1, high, turn + 1), a[high] * turn + Solve(dp, a, low, high - 1, turn + 1));

            return 0;
        }
    }
}
