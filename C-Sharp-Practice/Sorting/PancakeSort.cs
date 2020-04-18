using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.Sorting
{
    public class PancakeSort
    {

        public int[] Sort(int[] arr, int n)
        {


            for (int curr_size = n; curr_size > 1; --curr_size)
            {

                int mi = FindMax(arr, curr_size);

                if (mi != curr_size - 1)
                {
                    Flip(arr, mi);
                    Flip(arr, curr_size - 1);
                }

            }

            return arr;
        }

        private void Flip(int[] arr, int i)
        {

            int temp, start = 0;

            while (start < i)
            {
                temp = arr[start];
                arr[start] = arr[i];
                arr[i] = temp;
                start++;
                i--;
            }
        }
        private int FindMax(int[] arr, int n)
        {
            int mi, i;

            for (mi = 0, i = 0; i < n; ++i)
            {
                if (arr[i] > arr[mi])
                {
                    mi = i;
                }
            }
            return mi;
        }

    }
}

