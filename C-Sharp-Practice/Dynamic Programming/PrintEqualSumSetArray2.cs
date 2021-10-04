using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class PrintEqualSumSetArray2
    {
        void PrintEqualSumSets(int[] arr, int n)
        {
            int i, currSum, sum = 0;

            for (i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            if ((sum & 1) == 1)
            {
                Console.Write("-1");
                return;
            }

            int k = sum >> 1;
            bool[,] dp = new bool[n + 1, k + 1];

            for (i = 0; i <= k; i++)
            {
                dp[0, i] = false;
            }

            for (i = 0; i < n; i++)
            {
                dp[i, 0] = true;
            }

            for (i = 1; i <= n; i++)
            {
                for (currSum = 1; currSum < k; currSum++)
                {
                    dp[i, currSum] = dp[i - 1, currSum];
                }

                if (arr[i - 1] <= currSum)
                {
                    dp[i, currSum] = dp[i, currSum] | dp[i - 1, currSum - arr[i - 1]];
                }
            }

            List<int> set1 = new List<int>();
            List<int> set2 = new List<int>();

            if (!dp[n, k])
            {
                Console.Write("-1\n");
                return;
            }


            i = n;
            currSum = k;

            while (i > 0 && currSum >= 0)
            {
                if (dp[i - 1, currSum])
                {
                    i--;
                    set2.Add(arr[i]);
                }
                else if (dp[i - 1, currSum - arr[i - 1]])
                {
                    i--;
                    currSum -= arr[i];
                    set1.Add(arr[i]);
                }
            }

            Console.Write("Set 1 elements : ");
            for (i = 0; i < set1.Count; i++)
            {
                Console.Write(set1[i] + " ");
            }


            Console.Write("Set 2 elements : ");
            for (i = 0; i < set2.Count; i++)
            {
                Console.Write(set2[i] + " ");
            }
        }
    }
}
