using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class LargestSumContiguousSubarray2
    {
        int MaxSubArraySum(int[] a, int size)
        {
            int max_so_far = a[0], max_ending_here = 0;

            for (int i = 0; i < size; i++)
            {
                max_ending_here = max_ending_here + a[i];

                if (max_ending_here < 0)
                {
                    max_ending_here = 0;
                }
                else if (max_so_far < max_ending_here)
                {
                    max_so_far = max_ending_here;
                }
            }

            return max_so_far;
        }
    }
}
