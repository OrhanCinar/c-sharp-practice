using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.Sorting
{
    public class SortNearlySortedArray
    {
        public void InsertionSort(int[] a, int size)
        {
            int i, key, j;

            for (i = 0; i < size; i++)
            {
                key = a[i];
                j = i - 1;

                while (j >= 0 && a[j] > key)
                {
                    a[j + 1] = a[j];
                    j = j - 1;
                }

                a[j + 1] = key;
            }
        }
    }
}
