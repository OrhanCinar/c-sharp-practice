using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.Sorting
{
    public class SelectionSort
    {
        public int[] Sort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n-1; i++)
            {
                int min_idx = i;

                for (int j = i+1; j < n; j++)
                {
                    if (arr[j] < arr[min_idx])
                    {
                        min_idx = j;
                    }
                }

                int temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;
            }

            return arr;
        }
    }
}
