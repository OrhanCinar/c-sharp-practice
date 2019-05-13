using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.Arrays
{
    public class ArraySplit
    {
        public int[] GetSplitArray(int[] arr, int n, int k)
        {
            for (int i = 0; i < k; i++)
            {
                int x = arr[0];
                for (int j = 0; j < n-1; j++)
                {
                    arr[j] = arr[j + 1];
                }
                arr[n - 1] = x;
            }

            return arr;
        }
    }
}
