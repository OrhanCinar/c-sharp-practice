using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class FindAllDistinctSubsetSumsOfArray
    {
        void DistSumRec(int[] arr, int n, int sum, int currindex, HashSet<int> s)
        {
            if (currindex > n)
            {
                return;
            }

            if (currindex == n)
            {
                s.Add(sum);
                return;
            }

            DistSumRec(arr, n, sum + arr[currindex], currindex + 1, s);
            DistSumRec(arr, n, sum, currindex + 1, s);
        }

        void PrintDistSum(int[] arr, int n)
        {
            HashSet<int> s = new HashSet<int>();
            DistSumRec(arr, n, 0, 0, s);

            foreach (int i in s)
            {
                Console.Write(i + " ");
            }
        }
    }
}
