using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class MaxSumIncreasingSubSeq
    {
        int MaxSumIs(int[] arr, int n)
        {
            int i, j, max = 0;
            int[] msis = new int[n];

            for (i = 0; i < n; i++)
            {
                msis[i] = arr[i];
            }

            for (i = 1; i < n; i++)
            {
                for (j = 0; j < i; j++)
                {
                    if (arr[i] > arr[j] && msis[i] < msis[j] + arr[i])
                    {
                        msis[i] = msis[j] + arr[i];
                    }
                }
            }

            for (i = 0; i < n; i++)
            {
                if (max < msis[i])
                {
                    max = msis[i];
                }
            }

            return max;
        }
    }
}
