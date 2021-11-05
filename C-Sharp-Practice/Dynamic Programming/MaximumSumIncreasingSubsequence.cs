using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class MaximumSumIncreasingSubsequence
    {
        int FindSum(List<int> arr)
        {
            int sum = 0;

            foreach (var item in arr)
            {
                sum += item;
            }

            return sum;
        }

        void PrintMaxSumIs(int[] arr, int n)
        {
            List<int>[] L = new List<int>[n];

            for (int i = 0; i < n; i++)
            {
                L[i] = new List<int>();
            }

            L[0].Add(arr[0]);

            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if ((arr[i] > arr[j]) && (FindSum(L[i]) < FindSum(L[j])))
                    {
                        foreach (var k in L[j])
                        {
                            if (!L[i].Contains(k))
                            {
                                L[i].Add(k);
                            }
                        }
                    }
                }
                L[i].Add(arr[i]);
            }

            List<int> res = new List<int>(L[0]);

            foreach (var x in L)
            {
                if (FindSum(x) > FindSum(res))
                {
                    res = x;
                }

            }

            foreach (var i in res)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }
    }
}
