using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class WaysToSumNArrRepetition
    {
        int[] arr = { 1, 5, 6 };

        int CountWays(int N)
        {
            int[] count = new int[N + 1];
            count[0] = 1;

            for (int i = 1; i <= N; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i >= arr[j])
                    {
                        count[i] += count[i - arr[j]];
                    }
                }
            }

            return count[N];
        }
    }
}
