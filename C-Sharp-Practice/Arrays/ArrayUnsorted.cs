using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.Arrays
{
    public class ArrayUnsorted
    {
        public int FindKSmallestElement(int[] arr, int k)
        {
            var element = 0;

            Array.Sort(arr);

            element = arr[k-1];

            return element;
        }
    }
}
