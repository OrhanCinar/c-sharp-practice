using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.Arrays
{
    public class ArrayUnsorted
    {
        public int FindKSmallestElement(int[] arr, int k)
        {
            var element = 0;

            Array.Sort(arr);

            element = arr[k - 1];

            return element;
        }

        public int FindKSmallestElementOptimized(int[] arr, int position, int length, int findPositionOf)
        {


            if (findPositionOf > 0 && findPositionOf <= length - position + 1)
            {
                int pos = partition(arr, position, length);

                if (pos - position == findPositionOf - 1)
                {
                    return arr[pos];
                }

                if (pos - position > findPositionOf - 1)
                {
                    return FindKSmallestElementOptimized(arr, position, pos - 1, findPositionOf);
                }

                return FindKSmallestElementOptimized(arr, pos + 1, length, findPositionOf - pos + position - 1);
            }


            //local function
            int partition(int[] arr, int l, int r)
            {

                int x = arr[r];
                int i = l;
                int temp;

                for (int j = l; j <= r - 1; j++)
                {

                    if (arr[j] <= x)
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                        i++;
                    }
                }

                temp = arr[i];
                arr[i] = arr[r];
                arr[r] = temp;

                return i;
            }


            return int.MaxValue;

        }

        public int FindKSmallestElement2(int[] arr, int position, int length, int findPositionOf)
        {
            var element = 0;

            if (findPositionOf > 0 && findPositionOf <= length - position + 1)
            {
                int pos = randomPartition(arr, position, length);

                if (pos - position == findPositionOf - 1)
                {
                    return arr[pos];
                }

                if (pos - position > findPositionOf - 1)
                {
                    return FindKSmallestElement2(arr,position, length-1, findPositionOf);
                }

                return FindKSmallestElement2(arr, position+1, length, findPositionOf - pos + position-1);
            }

            return int.MaxValue;

            static int randomPartition(int[] arr, int position, int length)
            {
                int n = length;
                Random rnd = new Random();
                int rand = rnd.Next(0, 1);
                int pivot = (int)(rand * (n - 1));
                swap(arr, position + pivot, length);
                return partition(arr, position, length);

            }

            static int partition(int[] arr, int position, int length)
            {
                int x = arr[length], i = position;

                for (int j = position; j <= length - 1; j++)
                {
                    if (arr[j] <= x)
                    {
                        swap(arr, i, j);
                        i++;
                    }
                }
                swap(arr, i, length);
                return i;
            }

            static void swap(int[] arr, int i, int length)
            {
                int tmp = arr[i];
                arr[i] = arr[length];
                arr[length] = tmp;
            }


            return element;
        }


    }
}
