using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class LongestBitonicSubsequence2
    {
        void Print(List<int> arr, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        void PrintLBS(int[] arr, int n)
        {
            List<int>[] LIS = new List<int>[n];

            for (int i = 0; i < n; i++)
            {
                LIS[i] = new List<int>();
            }

            LIS[0].Add(arr[0]);


            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if ((arr[i] > arr[j]) && LIS[j].Count > LIS[i].Count)
                    {
                        foreach (var item in LIS[j])
                        {
                            if (!LIS[i].Contains(item))
                            {
                                LIS[i].Add(item);
                            }
                        }
                    }
                }

                LIS[i].Add(arr[i]);
            }


            List<int>[] LDS = new List<int>[n];

            for (int i = 0; i < n; i++)
            {
                LDS[i] = new List<int>();
            }

            LDS[n - 1].Add(arr[n - 1]);

            for (int i = n - 2; i >= 0; i--)
            {

                for (int j = n - 1; j > i; j--)
                {
                    if (arr[j] < arr[i] && LDS[j].Count > LDS[i].Count)
                    {
                        foreach (var item in LDS[j])
                        {
                            if (!LDS[i].Contains(item))
                            {
                                LDS[i].Add(item);
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                LDS[i].Reverse();
            }

            int max = 0;
            int maxIndex = -1;

            for (int i = 0; i < n; i++)
            {
                if (LIS[i].Count + LDS[i].Count - 1 > max)
                {
                    max = LIS[i].Count + LDS[i].Count - 1;
                    maxIndex = i;
                }
            }

            Print(LIS[maxIndex], LIS[maxIndex].Count - 1);
            Print(LDS[maxIndex], LDS[maxIndex].Count);
        }
    }
}
