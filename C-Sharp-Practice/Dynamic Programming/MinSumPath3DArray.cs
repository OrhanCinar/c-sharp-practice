using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class MinSumPath3DArray
    {
        int l = 3;
        int m = 3;
        int n = 3;


        int Min(int x, int y, int z)
        {
            return (x < y) ? ((x < z) ? x : z) :
                  ((y < z) ? y : z);
        }

        int MinPathSum(int[,,] arr)
        {
            int i, j, k;
            int[,,] tSum = new int[l, m, n];

            tSum[0, 0, 0] = arr[0, 0, 0];

            for (i = 1; i < l; i++)
            {
                tSum[i, 0, 0] = tSum[i - 1, 0, 0] + arr[i, 0, 0];
            }

            for (j = 1; j < m; j++)
            {
                tSum[0, j, 0] = tSum[0, j - 1, 0] + arr[0, j, 0];
            }

            for (k = 1; k < n; k++)
            {
                tSum[0, 0, k] = tSum[0, 0, k - 1] + arr[0, 0, k];
            }

            for (i = 1; i < l; i++)
            {
                for (k = 1; k < n; k++)
                {
                    tSum[i, 0, k] = Min(tSum[i - 1, 0, k], tSum[i, 0, k - 1], int.MaxValue) + arr[i, 0, k];
                }
            }

            for (k = 1; k < n; k++)
            {
                for (j = 1; j < m; j++)
                {
                    tSum[0, j, k] = Min(tSum[0, j, k - 1], tSum[0, j - 1, k], int.MaxValue) + arr[0, j, k];
                }
            }


            for (i = 1; i < l; i++)
            {
                for (j = 1; j < m; j++)
                {
                    for (k = 1; k < n; k++)
                    {
                        tSum[i, j, k] = Min(tSum[i - 1, j, k], tSum[i, j - 1, k], tSum[i, j, k - 1]) + arr[i, j, k];
                    }
                }
            }
            return tSum[l - 1, m - 1, n - 1];

        }
    }
}
