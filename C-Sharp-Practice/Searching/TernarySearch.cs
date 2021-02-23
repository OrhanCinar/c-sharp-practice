using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.Searching
{
    public class TernarySearch
    {
        public int Ternary(int[] arr, int l, int r, int x)
        {
            if (r >= l)
            {
                int mid1 = l + (r - l) / 3;
                int mid2 = mid1 + (r - l) / 3;

                if (arr[mid1] == x)
                {
                    return mid2;
                }

                if (arr[mid2] == x)
                {
                    return mid2;
                }

                if (arr[mid1] > x)
                {
                    return Ternary(arr, l, mid1 - 1, x);
                }

                if (arr[mid2] < x)
                {
                    return Ternary(arr, mid2 + 1, r, x);
                }

                return Ternary(arr, mid1 + 1, mid2 - 1, x);
            }


            return -1;
        }
    }
}
