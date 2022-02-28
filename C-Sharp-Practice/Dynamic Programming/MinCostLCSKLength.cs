using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class MinCostLCSKLength
    {
        int N = 30;

        int Solve(char[] X, char[] Y, int l, int r, int k, int[,,] dp)
        {
            if (k == 0)
            {
                return 0;
            }

            if (dp[l, r, k] != -1)
            {
                return dp[l, r, k];
            }

            int cos = (X[l] - 'a') ^ (Y[r] - 'a');

            return dp[l, r, k] = Math.Min(Math.Min(Solve(X, Y, l - 1, r - 1, k - 1, dp), Solve(X, Y, l - 1, r, k, dp)), Solve(X, Y, l, r - 1, k, dp));
        }
    }
}
