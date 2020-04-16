using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.Sorting
{
    public class BitonicSort
    {
        public int[] Sort(int[] arr, int n, int up)
        {

            BitonicSorting(arr, 0, n, up);

            return arr;
        }

        private void BitonicSorting(int[] arr, int low, int cnt, int dir)
        {
            if (cnt > 1)
            {
                int k = cnt / 2;

                BitonicSorting(arr, low, k, 1);

                BitonicSorting(arr, low + k, k, 0);

                Merge(arr, low, cnt, dir);

            }
        }

        private void Merge(int[] arr, int low, int cnt, int dir)
        {
            if (cnt > 1)
            {
                int k = cnt / 2;
                for (int i = low; i < low + k; i++)
                {
                    CompareAndSwap(arr, i, i + k, dir);                  
                }
                BitonicSorting(arr, low, k, dir);
                BitonicSorting(arr, low + k, k, dir);
            }
        }

        private void CompareAndSwap(int[] arr, int i, int j, int dir)
        {
            int k;
            if (arr[i] > arr[j])
            {
                k = 1;
            }
            else
            {
                k = 0;
            }

            if (dir == k)
            {
                Swap(ref arr[i], ref arr[j]);
            }

        }

        private void Swap(ref int v1, ref int v2)
        {
            int temp;

            temp = v1;
            v1 = v2;
            v2 = temp;

        }
    }
}
