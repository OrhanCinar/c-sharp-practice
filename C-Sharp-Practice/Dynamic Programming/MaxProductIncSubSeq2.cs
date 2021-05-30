using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class MaxProductIncSubSeq2
    {
        int[] arr = { 100, 1000, 100, 1000, 1 };
        int[] sum = new int[10000];

        int MaxSumWO3Consec(int n)
        {
            if (sum[n] != -1)
            {
                return sum[n];
            }

            if (n == 0)
            {
                return sum[n] = 0;
            }

            if (n == 1)
            {
                return sum[n] = arr[0];
            }

            if (n == 2)
            {
                return sum[n] = arr[1] + arr[0];
            }

            return sum[n] = Math.Max(Math.Max(MaxSumWO3Consec(n - 1), MaxSumWO3Consec(n - 2) + arr[n]), arr[n] + arr[n - 1] + MaxSumWO3Consec(n - 3));
        }
    }
}
