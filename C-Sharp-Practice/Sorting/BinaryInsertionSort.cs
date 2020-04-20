using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.Sorting
{
    public class BinaryInsertionSort
    {
        public int[] Sort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int x = arr[i];
                int j = Math.Abs(Array.BinarySearch(arr, 0, i, x) + 1);

                Array.Copy(arr, j, arr, j + 1, i - j);
                arr[j] = x;
            }

            return arr;
        }
    }
}
