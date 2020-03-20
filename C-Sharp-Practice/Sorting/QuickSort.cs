using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.Sorting
{
    public class QuickSort
    {
        public int[] Sort(int[] arr, int low , int high)
        {
            if (low< high)
            {
                int partionIndex = Partition(arr, low, high);
                Sort(arr, low, partionIndex-1);
                Sort(arr, partionIndex + 1, high);

            }

            return arr;
        }

        private int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];

            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;

                    int tmp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tmp;
                }
            }



            int tmp1 = arr[i+1];
            arr[i+1] = arr[high];
            arr[high] = tmp1;

            return i+1;
        }
    }
}
