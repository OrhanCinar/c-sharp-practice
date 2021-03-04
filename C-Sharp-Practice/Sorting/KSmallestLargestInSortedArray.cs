using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.Sorting
{
    public class KSmallestLargestInSortedArray
    {
        public int KSmallest(int[] arr, int k)
        {
            Array.Sort(arr);
            return arr[k - 1];
        }
    }
}
