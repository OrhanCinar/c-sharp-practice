using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    public class LongestCommonSubsequence
    {
        public int LCS(char[] X, char[] Y, int m, int n)
        {
            if (m == 0 || n == 0)
            {
                return 0;
            }

            if (X[m - 1] == Y[n - 1])
            {
                return 1 + LCS(X, Y, m - 1, n - 1);
            }

            return Max(LCS(X, Y, m, n - 1), LCS(X, Y, m - 1, n));
        }

        private int Max(int a, int b)
        {
            return a > b ? a : b;
        }
    }
}
