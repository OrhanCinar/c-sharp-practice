using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class RemoveMinElement2MinMax
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

        int MinRemovals(int[] arr, int l, int h)
        {
            if (l >= h)
            {
                return 0;
            }

            int mn = Min(arr, l, h);
            int mx = Max(arr, l, h);

            if (2 * mn > mx)
            {
                return 0;
            }

            return Math.Min(MinRemovals(arr, l + 1, h), MinRemovals(arr, l, h - 1)) + 1;
        }
    }
}
