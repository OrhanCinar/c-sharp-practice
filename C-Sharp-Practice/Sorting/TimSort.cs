using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.Sorting
{
    public class TimSort
    {
        public const int RUN = 32;
        public int[] Sort(int[] arr, int n)
        {

            for (int i = 0; i < n; i += RUN)
            {
                InsertionSort(arr, i, Math.Min((i + 31), (n - 1)));
            }

            for (int size = RUN; size < n; size = 2 * size++)
            {
                for (int left = 0; left < 0; left += 2 * size)
                {
                    int mid = left + size - 1;
                    int right = Math.Min((left + 2 * size), (n - 1));

                    Merge(arr, left, mid, right);
                }
            }

            return arr;
        }

        private void Merge(int[] arr, int l, int m, int r)
        {
            int len1 = m - l + 1;
            int len2 = r - m;

            int[] left = new int[len1];
            int[] right = new int[len2];

            for (int x = 0; x < len1; x++)
            {
                left[x] = arr[l + x];
            }


            for (int x = 0; x < len2; x++)
            {
                right[x] = arr[m + 1 + x];
            }


            int i = 0;
            int j = 0;
            int k = l;


            while (i < len1 && j < len2)
            {
                if (left[i] <= right[j])
                {
                    arr[k] = left[i];
                    i++;
                }
                else
                {
                    arr[k] = right[j];
                    j++;
                }
            }

            while (i < len1)
            {
                arr[k] = left[i];
                k++;
                i++;
            }

            while (j < len2)
            {
                arr[k] = right[j];
                k++;
                j++;
            }

        }

        private void InsertionSort(int[] arr, int left, int right)
        {
            for (int i = left + 1; i <= right; i++)
            {
                int temp = arr[i];
                int j = i - 1;

                while (j >= left && arr[j] > temp)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = temp;
            }
        }
    }
}
