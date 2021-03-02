using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.Sorting
{
    public class SortArrayWaveForm
    {
        void Swap(int[] arr, int a, int b)
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }

        void SortInWave(int[] arr, int n)
        {
            Array.Sort(arr);

            for (int i = 0; i < n - 1; i += 2)
            {
                Swap(arr, i, i + 1);
            }
        }
    }
}
