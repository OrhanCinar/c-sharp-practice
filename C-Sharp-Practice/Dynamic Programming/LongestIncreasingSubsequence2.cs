using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class LongestIncreasingSubsequence2
    {
        int Lis(int[] arr, int n)
        {
            int[] lis = new int[n];
            int i, j, max = 0;

            for (i = 0; i < n; i++)
            {
                lis[i] = 1;
            }

            for (i = 1; i < n; i++)
            {
                for (j = 0; j < i; j++)
                {
                    if (arr[i] > arr[j] && lis[i] < lis[j] + 1)
                    {
                        lis[i] = lis[j] + 1;
                    }
                }
            }

            for (i = 0; i < n; i++)
            {
                if (max < lis[i])
                {
                    max = lis[i];
                }
            }

            return max;
        }
    }
}
