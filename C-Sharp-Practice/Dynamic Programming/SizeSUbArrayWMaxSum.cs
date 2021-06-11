using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class SizeSUbArrayWMaxSum
    {
        int MaxSubArraySum(int[] a, int size)
        {
            int max_so_far = int.MinValue, max_ending = 0, start = 0, end = 0, s = 0;

            for (int i = 0; i < size; i++)
            {
                max_ending += a[i];

                if (max_so_far < max_ending)
                {
                    max_so_far = max_ending;
                    start = s;
                    end = i;
                }

                if (max_ending < 0)
                {
                    max_ending = 0;
                    s = i + 1;
                }
            }

            return end - start + 1;
        }
    }
}
