using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.Sorting
{
    public class InsertionSort
    {
        public int[] Sort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = key;
            }

            return arr;
        }
    }
}
