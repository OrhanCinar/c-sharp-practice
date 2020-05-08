using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.Searching
{
    public class ExponentialSearch
    {
        public int Search(int[] arr, int n, int x)
        {
            if (arr[0] == x)
            {
                return 0;
            }


            int i = 1;

            while (i < n && arr[i] <= x)
            {
                i *= 2;
            }



            return BinarySearch(arr, i / 2, Math.Min(i, n), x);
        }


        private int BinarySearch(int[] arr, int l, int r, int x)
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
                    return BinarySearch(arr, l, mid - 1, x);
                }

                return BinarySearch(arr, mid + 1, r, x);

            }

            return -1;
        }
    }
}
