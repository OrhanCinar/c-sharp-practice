using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class LongestAlternatingSubSeq2
    {
        int LAS(int[] arr, int n)
        {
            int inc = 1;
            int dec = 1;

            for (int i = 1; i < n; i++)
            {
                if (arr[i] > arr[i - 1])
                {
                    inc = dec + 1;
                }
                else if (arr[i] < arr[i - 1])
                {
                    dec = inc + 1;
                }
            }

            return Math.Max(inc, dec);
        }
    }
}
