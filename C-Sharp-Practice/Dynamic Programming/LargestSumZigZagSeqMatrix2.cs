using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class LargestSumZigZagSeqMatrix2
    {
        int MAX = 100;
        int[,] dp;

        public LargestSumZigZagSeqMatrix2()
        {
            dp = new int[MAX, MAX];
        }


        int LargestZigZagSumRec(int[,] mat, int i, int j, int n)
        {

            if (dp[i, j] != -1)
            {
                return dp[i, j];
            }

            if (i == n - 1)
            {
                return (dp[i, j] = mat[i, j]);
            }

            int zzs = 0;

            for (int k = 0; k < n; k++)
            {
                if (k != j)
                {
                    zzs = Math.Max(zzs, LargestZigZagSumRec(mat, i + 1, k, n));
                }
            }

            return (dp[i, j] = (zzs + mat[i, j]));
        }

        int LargestZigZag(int[,] mat, int n)
        {

            for (int i = 0; i < MAX; i++)
            {
                for (int k = 0; k < MAX; k++)
                {
                    dp[i, k] = -1;
                }
            }

            int res = 0;

            for (int j = 0; j < n; j++)
            {
                res = Math.Max(res, LargestZigZagSumRec(mat, 0, j, n));
            }

            return res;
        }
    }
}
