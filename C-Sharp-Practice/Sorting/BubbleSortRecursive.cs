using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.Sorting
{
    public class BubbleSortRecursive
    {
        public int[] Sort(int[] arr, int n)
        {

            if (n == 1)
            {
                return arr;
            }

            for (int i = 0; i < n-1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    int temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i+1] = temp;
                }
            }

            Sort(arr, n-1);

            return arr;
        }
    }
}
