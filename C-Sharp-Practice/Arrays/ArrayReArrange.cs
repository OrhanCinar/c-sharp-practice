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
    }
}
