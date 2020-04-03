﻿using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.Sorting
{
    public class HeapSort
    {
        public int[] Sort(int[] arr)
        {
            int n = arr.Length;

            for (int i = n / 2 - 1; i >= 0; i--)
            {
                heapify(arr, n, i);
            }

            for (int i = n - 1; i >= 0; i--)
            {
                int tmp = arr[0];
                arr[0] = arr[i];
                arr[i] = tmp;

                heapify(arr,i,0);
            }

            return arr;
        }

        private void heapify(int[] arr, int n, int i)
        {
            int largest = i;
            int l = 2 * i + 1;
            int r = 2 * i + 2;

            if (l < n && arr[l] > arr[largest])
            {
                largest = l;
            }

            if (r < n && arr[r] > arr[largest])
            {
                largest = r;
            }

            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;

                heapify(arr,n , largest);
            }
        }
    }
}
