using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.Sorting
{
    public class KSmallestLargestInUnSortedArray
    {
        public int KSmallest(int[] arr, int l, int r, int k)
        {
            if (k > 0 && k <= r - l + 1)
            {
                int pos = RandomPartition(arr, l, r);

                if (pos - l == k - 1)
                {
                    return arr[pos];
                }

                if (pos - l > k - 1)
                {
                    return KSmallest(arr, l, pos - 1, k);
                }

                return KSmallest(arr, pos + 1, r, k - pos + l - 1);
            }

            return int.MaxValue;
        }

        private int RandomPartition(int[] arr, int l, int r)
        {
            int n = r - l + 1;

            Random rnd = new Random();
            int rand = rnd.Next(0, 1);

            int pivot = (int)(rand * (n - 1));
            Swap(arr, l + pivot, r);


            return Partition(arr, l, r);
           
        }

        private int Partition(int[] arr, int l, int r)
        {
            int x = arr[r], i = l;

            for (int j = l; j <= r-1; j++)
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

        private void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
