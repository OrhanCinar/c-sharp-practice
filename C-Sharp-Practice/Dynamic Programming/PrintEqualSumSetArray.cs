using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class PrintEqualSumSetArray
    {
        void PrintSets(List<int> set1, List<int> set2)
        {
            int i;

            for (i = 0; i < set1.Count; i++)
            {
                Console.Write(set1[i] + " ");
            }

            Console.WriteLine();

            for (i = 0; i < set2.Count; i++)
            {
                Console.Write(set2[i] + " ");
            }
        }


        bool findSets(int[] arr, int n, ref List<int> set1, ref List<int> set2, int sum1, int sum2, int pos)
        {
            if (pos == n)
            {
                if (sum1 == sum2)
                {
                    PrintSets(set1, set2);
                    return true;
                }
                else
                {
                    return false;
                }
            }

            set1.Add(arr[pos]);

            bool res = findSets(arr, n, ref set1, ref set2, sum1 + arr[pos], sum2, pos + 1);

            if (res)
            {
                return res;
            }

            set1.RemoveAt(set1.Count - 1);
            set2.Add(arr[pos]);

            res = findSets(arr, n, ref set1, ref set2, sum1, sum2 + arr[pos], pos + 1);

            if (!res)
            {
                if (set2.Count > 0)
                {
                    set2.RemoveAt(set2.Count - 1);
                }
            }

            return false;
        }

        bool IsPartitionPoss(int[] arr, int n)
        {
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += arr[i];
            }

            if (sum % 2 != 0)
            {
                return false;
            }

            List<int> set1 = new List<int>();
            List<int> set2 = new List<int>();

            return findSets(arr, n, ref set1, ref set2, 0, 0, 0);
        }
    }
}
