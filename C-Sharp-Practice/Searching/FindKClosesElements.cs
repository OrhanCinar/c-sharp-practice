using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.Searching
{
    public class FindKClosesElements
    {
        int FindCrossOver(int[] arr, int low, int high, int x)
        {
            if (arr[high] <= x)
            {
                return high;
            }

            if (arr[low] > x)
            {
                return low;
            }

            int mid = (low + high) / 2;

            if (arr[mid] <= x & arr[mid + 1] > x)
            {
                return mid;
            }

            if (arr[mid] < x)
            {
                return FindCrossOver(arr, mid + 1, high, x);
            }

            return FindCrossOver(arr, low, mid - 1, x);
        }

        public void PrintKClosest(int[] arr, int x, int k, int n)
        {
            int l = FindCrossOver(arr, 0, n - 1, x);

            int r = l + 1;

            int count = 0;

            if (arr[l] == x)
            {
                l--;
            }

            while (l >= 0 && r < n && count < k)
            {
                if (x - arr[l] < arr[r] - x)
                {
                    Console.Write(arr[l--] + " ");
                }
                else
                {
                    Console.Write(arr[r++] + " ");
                }
            }

            while (count < k && r < n)
            {
                Console.Write(arr[r++] + " ");
                count++;
            }
        }
    }
}
