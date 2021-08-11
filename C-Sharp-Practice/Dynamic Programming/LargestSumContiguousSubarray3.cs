using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class LargestSumContiguousSubarray3
    {
        int MaxSubArraySum(int[] a, int size)
        {

            int max_so_far = a[0];
            int curr_max = a[0];

            for (int i = 1; i < size; i++)
            {
                curr_max = Math.Max(a[i], curr_max + a[i]);
                max_so_far = Math.Max(max_so_far, curr_max);
            }


            return max_so_far;
        }
    }
}
