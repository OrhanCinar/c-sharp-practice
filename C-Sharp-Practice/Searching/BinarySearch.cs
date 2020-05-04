using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.Searching
{
    public class BinarySearch
    {
        public int Search(int[] arr, int l, int r, int x)
        {

            if (r >= l)
            {
                int mid = l + (r - l) / 2;

                if (arr[mid] == x)
                {
                    return mid;
                }

                if (arr[mid] > x)
                {
                    return Search(arr, l, mid - 1, x);
                }

                return Search(arr, mid + 1, r, x);

            }

            return -1;
        }
    }
}
