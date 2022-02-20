using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class RemoveMinElement2MinMax2
    {
        int Min(int[] arr, int l, int h)
        {
            int mn = arr[l];

            for (int i = l + 1; i <= h; i++)
            {
                if (mn > arr[i])
                {
                    mn = arr[i];
                }
            }

            return mn;
        }

        int Max(int[] arr, int l, int h)
        {
            int mx = arr[l];

            for (int i = l + 1; i <= h; i++)
            {
                if (mx < arr[i])
                {
                    mx = arr[i];
                }
            }

            return mx;
        }

        int MinRemovalsDP(int[] arr, int n)
        {
            int[,] table = new int[n, n];
            int gap, i, j, mn, mx;

            for (gap = 0; gap < n; ++gap)
            {
                for (i = gap; i < n; ++i, ++j)
                {
                    mn = Min(arr, i, j);
                    mx = Max(arr, i, j);

                    table[i, j] = (2 * mn > mx) ? 0 : Math.Min(table[i, j - 1] + 1, table[i + 1, j] + 1);
                }
            }

            return table[0, n - 1];
        }
    }
}
