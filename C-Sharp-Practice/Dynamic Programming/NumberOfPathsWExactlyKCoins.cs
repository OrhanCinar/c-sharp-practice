using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class NumberOfPathsWExactlyKCoins
    {
        public const int R = 3;
        public const int C = 3;


        int PathCountRec(int[][] mat, int m, int n, int k)
        {
            if (m < 0 || n < 0)
            {
                return 0;
            }

            if (m == 0 && n == 0 && k == mat[m][n])
            {
                return 1;
            }


            return PathCountRec(mat, m - 1, n, k - mat[m][n]) + PathCountRec(mat, m, n - 1, k - mat[m][n]);
        }

        public int PathCount(int[][] mat, int k)
        {
            return PathCountRec(mat, R - 1, C - 1, k);
        }
    }
}
