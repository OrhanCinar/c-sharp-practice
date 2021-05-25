using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class MaxSumBiTonicSubSeq
    {
        int MaxSumBs(int[] arr, int n)
        {
            int max_sum = int.MinValue;

            int[] MSIBS = new int[n];
            int[] MSDBS = new int[n];

            for (int i = 0; i < n; i++)
            {
                MSDBS[i] = arr[i];
                MSIBS[i] = arr[i];
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] > arr[j] && MSIBS[i] < MSIBS[j] + arr[i])
                    {
                        MSIBS[i] = MSIBS[j] + arr[i];
                    }
                }
            }


            for (int i = n - 2; i >= 0; i--)
            {
                for (int j = n - 1; j >= i; j--)
                {
                    if (arr[i] > arr[j] && MSDBS[i] < MSDBS[j] + arr[i])
                    {
                        MSDBS[i] = MSDBS[j] + arr[i];
                    }
                }
            }


            for (int i = 0; i < n; i++)
            {
                max_sum = Math.Max(max_sum, (MSDBS[i] + MSIBS[i] - arr[i]));
            }

            return max_sum;
        }
    }
}
