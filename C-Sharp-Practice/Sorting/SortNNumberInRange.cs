using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.Sorting
{
    public class SortNNumberInRange
    {
        void CountSort(int[] arr, int n, int exp)
        {
            int[] output = new int[n];
            int[] count = new int[n];
            int i;

            for (i = 0; i < n; i++)
            {
                count[i] = 0;
            }

            for (i = 0; i < n; i++)
            {
                count[i] += count[i - 1];
            }

            for (i = n - 1; i >= 0; i--)
            {
                output[count[arr[i] / exp % n] - 1] = arr[i];
                count[(arr[i] / exp) % n]--;
            }

            for (i = 0; i < n; i++)
            {
                arr[i] = output[i];
            }
        }

        void Sort(int[] arr, int n)
        {
            CountSort(arr, n, 1);

            CountSort(arr, n, n);
        }
    }
}
