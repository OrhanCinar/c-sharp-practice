using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.Sorting
{
    public class MergeSortIterative
    {
        public int[] Sort(int[] arr, int n)
        {

            int curr_size;

            int left_start;

            for (curr_size = 1; curr_size <= n - 1; curr_size = 2 * curr_size)
            {

                for (left_start = 0; left_start < n-1; left_start += 2*curr_size)
                {
                    int mid = left_start + curr_size - 1;

                    int rigth_end = Math.Min(left_start + 2 * curr_size - 1, n - 1);
                    Merge(arr, left_start, mid, rigth_end);
                }
                
            }


            return arr;
        }

        private void Merge(int[] arr, int l, int m, int r)
        {
            int i, j, k;
            int n1 = m - l + 1;
            int n2 = r - m;

            int[] L = new int[n1];
            int[] R = new int[n2];


            for (i = 0; i < n1; i++)
            {
                L[i] = arr[l + i];
            }

            for (j = 0; j < n2; j++)
            {
                R[j] = arr[m + 1 + j];
            }

            i = 0;
            j = 0;
            k = l;

            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }



            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }
    }
}
