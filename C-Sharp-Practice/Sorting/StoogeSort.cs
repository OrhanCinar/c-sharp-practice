using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.Sorting
{
    public class StoogeSort
    {
        public int[] Sort(int[] arr, int l, int h)
        {

            if (l >= h)
            {
                return arr;
            }

            if (arr[l] > arr[h])
            {
                int t = arr[l];
                arr[l] = arr[h];
                arr[h] = t;
            }


            if (h - l + 1 > 2)
            {
                int t = (h - l + 1) / 3;

                Sort(arr, l, h - t);
                Sort(arr, l + t, h);
                Sort(arr, l, h - t);
            }

            return arr;
        }
    }
}
