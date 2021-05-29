using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class MaxSubSeqSumNo3Consecutive
    {
        int MaxSumWo3Consex(int[] arr, int n)
        {
            int[] sum = new int[n];

            if (n >= 1)
            {
                sum[0] = arr[0];
            }

            if (n >= 2)
            {
                sum[1] = arr[0] + arr[1];
            }

            if (n > 2)
            {
                sum[2] = Math.Max(sum[1], Math.Max(arr[1] + arr[2], arr[0] + arr[2]));
            }


            for (int i = 3; i < n; i++)
            {
                sum[i] = Math.Max(Math.Max(sum[i - 1], sum[i - 2] + arr[i]), arr[i] + arr[i - 1] + sum[i - 3]);
            }

            return sum[n - 1];
        }
    }
}
