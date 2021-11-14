using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class LargestSumZigZagSeqMatrix
    {
        int LargestZigZagSumRec(int[,] mat, int i, int j, int n)
        {
            if (i == n - 1)
            {
                return mat[i, j];
            }

            int zzs = 0;

            for (int k = 0; k < n; k++)
            {
                if (k != j)
                {
                    zzs = Math.Max(zzs, LargestZigZagSumRec(mat, i + 1, k, n));
                }
            }

            return zzs + mat[i, j];
        }

        int LargestZigZag(int[,] mat, int n)
        {
            int res = 0;

            for (int j = 0; j < n; j++)
            {
                res = Math.Max(res, LargestZigZagSumRec(mat, 0, j, n));
            }

            return res;
        }
    }
}
