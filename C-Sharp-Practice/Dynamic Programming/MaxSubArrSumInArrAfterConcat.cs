using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class MaxSubArrSumInArrAfterConcat
    {
        int MaxSubArraySumRepeated(int[] a, int n, int k)
        {

            int max_so_far = 0;
            int max_ending_here = 0;

            for (int i = 0; i < n; i++)
            {
                max_ending_here = max_ending_here + a[i % n];

                if (max_so_far < max_ending_here)
                {
                    max_so_far = max_ending_here;
                }

                if (max_ending_here < 0)
                {
                    max_ending_here = 0;
                }
            }

            return max_so_far;
        }
    }
}
