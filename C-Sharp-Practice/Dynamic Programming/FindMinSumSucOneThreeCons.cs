using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class FindMinSumSucOneThreeCons
    {
        int FindMinSum(int[] arr, int n)
        {
            int[] sum = new int[n];

            sum[0] = arr[0];
            sum[1] = arr[1];
            sum[2] = arr[2];

            for (int i = 3; i < n; i++)
            {
                sum[i] = arr[i] + Math.Min(sum[i - 3], Math.Min(sum[i - 2], sum[i - 1]));
            }

            return Math.Min(sum[n - 1], Math.Min(sum[n - 2], sum[n - 3]));
        }
    }
}
