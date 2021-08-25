using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class LongestAlternatingSubArray
    {
        void LongestAlternating(int[] arr, int n)
        {
            int[] count = new int[n];

            count[n - 1] = 1;

            for (int i = n - 2; i >= 0; i--)
            {
                if (arr[i] * arr[i + 1] < 0)
                {
                    count[i] = count[i + 1] + 1;
                }
                else
                {
                    count[i] = 1;
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(count[i] + " ");
            }
        }
    }
}
