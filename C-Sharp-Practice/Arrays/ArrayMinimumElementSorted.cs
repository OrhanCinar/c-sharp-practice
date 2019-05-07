﻿namespace C_Sharp_Practice.Arrays
{
    public class ArrayMinimumElementSorted
    {
        public int FindMin(int[] arr, int low, int high)
        {
            if (high < low)
            {
                return arr[0];
            }

            if (high == low)
            {
                return arr[low];
            }

            int mid = low + (high - low) / 2;

            if (mid < high && arr[mid + 1] < arr[mid])
            {
                return arr[mid + 1];
            }

            if (mid > low && arr[mid] < arr[mid - 1])
            {
                return arr[mid];
            }

            if (arr[high]> arr[mid])
            {
                return FindMin(arr, low, mid - 1);
            }

            return FindMin(arr, mid + 1, high);
        }
    }
}
