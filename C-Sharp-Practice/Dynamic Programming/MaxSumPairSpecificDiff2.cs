using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class MaxSumPairSpecificDiff2
    {
        int MaxSumPairWithDifferenceLessThanK(int[] arr, int N, int k)
        {
            int maxSum = 0;

            Array.Sort(arr);

            for (int i = N - 1; i > 0; --i)
            {
                if (arr[i] - arr[i - 1] < k)
                {
                    maxSum += arr[i];
                    maxSum += arr[i - 1];
                    --i;
                }
            }

            return maxSum;
        }
    }
}
