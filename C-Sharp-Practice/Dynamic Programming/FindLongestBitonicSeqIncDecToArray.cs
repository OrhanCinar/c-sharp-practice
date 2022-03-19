using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class FindLongestBitonicSeqIncDecToArray
    {
        List<int> res = new List<int>();

        int[] Reverse(int[] a)
        {

            int i, n = a.Length, t;

            for (i = 0; i < n / 2; i++)
            {
                t = a[i];
                a[i] = a[n - i - 1];
                a[n - i - 1] = t;
            }

            return a;
        }

        int GetCeilIndex(int[] arr, int[] T, int l, int r, int key)
        {
            while (r - l > 1)
            {
                int m = l + (r - l) / 2;

                if (arr[T[m]] >= key)
                {
                    r = m;
                }
                else
                {
                    l = m;
                }
            }

            return r;
        }

        void LIS(int[] arr, int n)
        {
            int[] tailIndices = new int[n];
            int[] prevIndices = new int[n];

            for (int i = 0; i < n; i++)
            {
                tailIndices[i] = 0;
                prevIndices[i] = -1;
            }

            int len = 1;

            for (int i = 1; i < n; i++)
            {
                if (arr[i] < arr[tailIndices[0]])
                {
                    tailIndices[0] = i;
                }
                else if (arr[i] > arr[tailIndices[len - 1]])
                {
                    prevIndices[i] = tailIndices[len - 1];
                    tailIndices[len++] = i;
                }
                else
                {
                    int pos = GetCeilIndex(arr, tailIndices, -1, len - 1, arr[i]);
                    prevIndices[i] = tailIndices[pos - 1];
                    tailIndices[pos] = i;
                }
            }


            for (int i = tailIndices[len - 1]; i >= 0; i = prevIndices[i])
            {
                res.Add(arr[i]);
            }
        }

        void LongestBitonic(int[] arr1, int n1, int[] arr2, int n2)
        {
            LIS(arr1, n1);
            res.Reverse();

            arr2 = Reverse(arr2);
            LIS(arr2, n2);

            for (int i = 0; i < res.Count; i++)
            {
                Console.Write(res[i] + " ");
            }
        }
    }
}
