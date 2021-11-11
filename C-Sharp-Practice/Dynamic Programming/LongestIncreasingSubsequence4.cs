using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class LongestIncreasingSubsequence4
    {
        void ConstructPrintLIS(int[] arr, int n)
        {
            List<List<int>> L = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                L.Add(new List<int>());
            }

            L[0].Add(arr[0]);

            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if ((arr[i] > arr[j]) && (L[i].Count < L[j].Count + 1))
                    {
                        L[i] = L[j];
                    }
                }

                L[i].Add(arr[i]);
            }

            List<int> max = L[0];

            foreach (var item in L)
            {
                if (item.Count > max.Count)
                {
                    max = item;
                }
            }

            PrintLIS(max);
        }

        void PrintLIS(List<int> arr)
        {
            foreach (int x in arr)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
        }
    }
}
