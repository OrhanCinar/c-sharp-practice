using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class FindAllDistinctSubsetSumsOfArray2
    {
        void PrintDistSum(int[] arr, int n)
        {
            int sum = 0;


            for (int i = 0; i < n; i++)
            {
                sum += arr[i];
            }

            bool[,] dp = new bool[n + 1, sum + 1];

            for (int i = 0; i <= n; i++)
            {
                dp[i, 0] = true;
            }

            for (int i = 0; i <= n; i++)
            {
                dp[i, arr[i - 1]] = true;

                for (int j = 1; j <= sum; j++)
                {
                    if (dp[i - 1, j])
                    {
                        dp[i, j] = true;
                        dp[i, j + arr[i - 1]] = true;
                    }
                }
            }

            for (int j = 0; j <= sum; j++)
            {
                if (dp[n, j])
                {
                    Console.Write(j + " ");
                }
            }
        }
    }
}
