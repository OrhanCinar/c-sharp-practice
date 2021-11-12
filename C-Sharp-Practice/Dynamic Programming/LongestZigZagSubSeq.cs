using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class LongestZigZagSubSeq
    {
        int Zzis(int[] arr, int n)
        {

            int[,] Z = new int[n, 2];

            for (int i = 0; i < n; i++)
            {
                Z[i, 0] = Z[i, 1] = 1;
            }


            int res = 1;

            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] < arr[i] && Z[i, 0] < Z[j, 1] + 1)
                    {
                        Z[i, 0] = Z[j, 0] + 1;
                    }

                    if (arr[j] > arr[i] && Z[i, 1] < Z[j, 0] + 1)
                    {
                        Z[i, 1] = Z[j, 0] + 1;
                    }
                }

                if (res < Math.Max(Z[i, 0], Z[i, 1]))
                {
                    res = Math.Max(Z[i, 0], Z[i, 1]);
                }
            }

            return res;
        }
    }
}
