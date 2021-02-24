﻿using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.Sorting
{
    public class FindMinLengthUnsortedSubarray
    {
        public void PrintUnsorted(int[] arr, int n)
        {
            int s = 0, e = n - 1, i, max, min;

            for (s = 0; s < n - 1; s++)
            {
                if (arr[s] > arr[s + 1])
                {
                    break;
                }
            }

            if (s == n - 1)
            {
                Console.Write("The Complete array is sorted");
                return;
            }

            for (e = n - 1; e > 0; e--)
            {
                if (arr[e] < arr[e - 1])
                {
                    break;
                }
            }

            max = arr[s];
            min = arr[s];

            for (i = s + 1; i <= e; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }

                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            for (i = 0; i < s; i++)
            {
                if (arr[i] > min)
                {
                    s = i;
                    break;
                }
            }

            for (i = n - 1; i >= e + 1; i--)
            {
                if (arr[i] < max)
                {
                    e = i;
                    break;
                }
            }

            Console.Write(" The unsorted subarray which makes the given array sorted lies  between the indices " + s + " and " + e);
        }
    }
}
