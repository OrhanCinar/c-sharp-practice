using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.Searching
{
    public class SearchInAlmosSortedArray
    {
        public int BinarySearch(int[] arr, int l, int r, int x)
        {
            if (r >= l)
            {
                int mid = l + (r - l) / 2;

                if (arr[mid] == x)
                {
                    return mid;
                }

                if (mid > l && arr[mid - 1] == x)
                {
                    return mid - 1;
                }

                if (mid < r && arr[mid + 1] == x)
                {
                    return mid + 1;
                }

                if (arr[mid] > x)
                {
                    return BinarySearch(arr, l, mid - 2, x);
                }

                return BinarySearch(arr, mid + 2, r, x);
            }

            return -1;
        }
    }
}
