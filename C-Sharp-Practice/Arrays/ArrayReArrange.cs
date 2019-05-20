using System.Collections.Generic;

namespace C_Sharp_Practice.Arrays
{
    public class ArrayReArrange
    {
        public int[] ReArrangeArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != -1 && arr[i] != i)
                {
                    int x = arr[i];

                    while (arr[x] != -1 && arr[x] != x)
                    {
                        int y = arr[x];

                        arr[x] = x;

                        x = y;
                    }

                    arr[x] = x;

                    if (arr[i] != i)
                    {
                        arr[i] = -1;
                    }
                }
            }

            return arr;
        }

        public int[] ReArrangeArray2(int[] arr)
        {
            HashSet<int> hashTable = new HashSet<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                hashTable.Add(arr[i]);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (hashTable.Contains(i))
                {
                    arr[i] = i;
                }
                else
                {
                    arr[i] = -1;
                }
            }

            return arr;
        }

        public int[] ReArrangeArraySwap(int[] arr)
        {
            for (int i = 0; i < arr.Length;)
            {
                if (arr[i] >= 0 && arr[i] != i)
                {
                    int element = arr[arr[i]];
                    arr[arr[i]] = arr[i];
                    arr[i] = element;
                }
                else
                {
                    i++;
                }
            }

            return arr;
        }

        public int[] ReArrangePositiveNegative(int[] arr, int n)
        {
            int i = -1;
            int tmp = 0;

            for (int j = 0; j < n; j++)
            {
                if (arr[j] < 0)
                {
                    i++;
                    tmp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tmp;
                }
            }

            int pos = i + 1;
            int neg = 0;

            while (pos < n && neg < pos && arr[neg] < 0)
            {
                tmp = arr[neg];
                arr[neg] = arr[pos];
                arr[pos] = tmp;
                pos++;
                neg += 2;
            }

            return arr;
        }
    }
}
