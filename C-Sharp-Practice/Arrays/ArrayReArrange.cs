using System;
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

        public int[] ReArrangePositiveNegativeAlternate(int[] arr, int n)
        {
            int outOfPlace = -1;

            for (int i = 0; i < n; i++)
            {
                if (outOfPlace >= 0)
                {
                    if ((arr[i] >= 0 && arr[outOfPlace] < 0) || (arr[i] < 0 && arr[outOfPlace] >= 0))
                    {
                        RightRotate(arr, n, outOfPlace, i);

                        if (i - outOfPlace > 2)
                        {
                            outOfPlace = outOfPlace + 2;
                        }
                        else
                        {
                            outOfPlace = -1;
                        }
                    }
                }

                if (outOfPlace == -1)
                {

                    if (((arr[i] >= 0) && ((i & 0x01) == 0)) || ((arr[i] < 0) && (i & 0x01) == 1))
                    {
                        outOfPlace = i;
                    }
                }
            }

            return arr;
        }

        private void RightRotate(int[] arr, int n, int outOfPlace, int curr)
        {
            int tmp = arr[curr];
            for (int i = curr; i > outOfPlace; i--)
            {
                arr[i] = arr[i - 1];
            }

            arr[outOfPlace] = tmp;
        }

        public int[] ReArrangeEvens(int[] arr, int n)
        {
            Array.Sort(arr);

            int[] ans = new int[n];
            int p = 0;
            int q = n - 1;

            for (int i = 0; i < n; i++)
            {
                ans[i] = (i + 1) % 2 == 0 ? arr[q--] : arr[p++];
            }

            return ans;
        }

        public int[] ReArrangeSmallest(int[] arr, int n)
        {
            Array.Sort(arr);

            int[] tempArr = new int[n];

            int ArrIndex = 0;

            for (int i = 0, j = n - 1; i <= n / 2 || j > n / 2; i++, j--)
            {
                if (ArrIndex < n)
                {
                    tempArr[ArrIndex] = arr[i];
                    ArrIndex++;
                }

                if (ArrIndex < n)
                {
                    tempArr[ArrIndex] = arr[j];
                    ArrIndex++;
                }
            }


            for (int i = 0; i < n; i++)
            {
                arr[i] = tempArr[i];
            }

            return arr;
        }

        public int[] DoubleFirstElementMoveZeroEnd(int[] arr, int n)
        {
            if (n == 1)
                return arr;


            for (int i = 0; i < n - 1; i++)
            {
                if (arr[i] != 0 && arr[i] == arr[i + 1])
                {
                    arr[i] = 2 * arr[i];

                    arr[i + 1] = 0;
                    i++;
                }
            }

            arr = pushZeros(arr, n);


            //local function
            int[] pushZeros(int[] array, int n)
            {
                int count = 0;

                for (int i = 0; i < n; i++)
                {
                    if (array[i] != 0)
                    {
                        array[count++] = array[i];
                    }
                }


                while (count < n)
                {
                    array[count++] = 0;
                }

                return array;
            }

            return arr;
        }
    }
}
