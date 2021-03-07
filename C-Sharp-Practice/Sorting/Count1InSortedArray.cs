using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.Sorting
{
    public class Count1InSortedArray
    {
        public int CountOnes(int[] arr, int low, int high)
        {
            if (high >= low)
            {
                int mid = low + (high - low) / 2;

                if ((mid == high || arr[mid + 1] == 0) && (arr[mid]) == 1)
                {
                    return mid + 1;
                }

                if (arr[mid] == 1)
                {
                    return CountOnes(arr, (mid + 1), high);
                }

                return CountOnes(arr, low, (mid - 1));
            }

            return 0;
        }
    }
}
