using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class MaxSubArraySumOn
    {
        int MaximumSumSubarray(int[] arr, int n)
        {
            int min_prefix_sum = 0;

            int res = int.MinValue;

            int[] prefix_sum = new int[n];
            prefix_sum[0] = arr[0];

            for (int i = 1; i < n; i++)
            {
                prefix_sum[i] = prefix_sum[i - 1] + arr[i];
            }

            for (int i = 0; i < n; i++)
            {
                res = Math.Max(res, prefix_sum[i] - min_prefix_sum);

                min_prefix_sum = Math.Max(min_prefix_sum, prefix_sum[i]);
            }

            return res;
        }
    }
}
