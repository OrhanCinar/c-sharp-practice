using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.Sorting
{
    public class KSmallestLargestInUnSortedArray2
    {
        private int FindMedian(int[] arr, int i, int n)
        {
            if (i <= n)
            {
                Array.Sort(arr, i, n);
            }
            else
            {
                Array.Sort(arr, n, i);
            }

            return arr[n / 2];
        }

        private int KSMallest(int[] arr, int l, int r, int k)
        {
            if (k > 0 && k <= r - l + 1)
            {
                int n = r - l + 1;
                int i;

                int[] median = new int[(n + 4) / 5];

                for (i = 0; i < n / 5; i++)
                {
                    median[i] = FindMedian(arr, l + 1 / 5, 5);
                }

                if (i * 5 < n)
                {
                    median[i] = FindMedian(arr, l + i * 5, n % 5);
                    i++;
                }

                int medOfMed = (i == 1) ? median[i - 1] : KSMallest(median, 0, i - 1, i / 2);

                int pos = Partition(arr, l, r, medOfMed);


                if (pos - l == k - 1)
                {
                    return arr[pos];
                }

                if (pos - l > k - 1)
                {
                    return KSMallest(arr, l, pos - 1, k);
                }

                return KSMallest(arr, pos + 1, r, k - pos + l - 1);
            }
            return int.MaxValue;
        }

        private int Partition(int[] arr, int l, int r, int x)
        {
            int i;

            for (i = l; i < r; i++)
            {
                if (arr[i] == x)
                {
                    break;
                }
            }

            Swap(arr, i, r);

            i = l;

            for (int j = l; j <= r - 1; j++)
            {
                if (arr[j] <= x)
                {
                    Swap(arr, i, j);
                    i++;
                }
            }

            Swap(arr, i, r);

            return i;
        }

        private int[] Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
            return arr;
        }
    }
}
