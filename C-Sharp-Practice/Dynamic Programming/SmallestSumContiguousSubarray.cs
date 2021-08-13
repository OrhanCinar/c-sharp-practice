using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class SmallestSumContiguousSubarray
    {
        int SmallestSumSubarr(int[] arr, int n)
        {
            int min_ending_here = 2147483647;
            int min_so_far = 2147483647;


            for (int i = 0; i < n; i++)
            {
                if (min_ending_here > 0)
                {
                    min_ending_here = arr[i];
                }
                else
                {
                    min_ending_here += arr[i];
                }

                min_so_far = Math.Min(min_so_far, min_ending_here);
            }

            return min_so_far;
        }
    }
}
