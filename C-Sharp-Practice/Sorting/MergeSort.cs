using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.Sorting
{
    public class MergeSort
    {
        public int[] Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                Sort(arr, left, middle); // sort left side
                Sort(arr, middle + 1, right); // sort right side

                Merge(arr, left, middle, right);
            }


            return arr;
        }

        private void Merge(int[] arr, int length, int middle, int right)
        {
            //size of arrays
            int n1 = middle - length + 1;
            int n2 = right - middle;

            int[] L = new int[n1];
            int[] R = new int[n2];

            {
                //copy to temp arrays
                for (int i = 0; i < n1; ++i)
                {
                    L[i] = arr[length + i];
                }

                for (int j = 0; j < n2; ++j)
                {
                    R[j] = arr[middle + 1 + j];
                }
            }

            {
                //subarray indexes
                int i = 0, j = 0;

                int k = length;

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

                //copy remaining elements L
                while(i < n1)
                {
                    arr[k] = L[i];
                    i++;
                    k++;
                }

                //copy remaining elements R
                while (j < n2)
                {
                    arr[k] = R[j];
                    j++;
                    k++;
                }
            }
        }
    }
}
