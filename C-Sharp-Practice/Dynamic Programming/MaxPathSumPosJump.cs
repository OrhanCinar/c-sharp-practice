using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class MaxPathSumPosJump
    {
        void PrintMaxSum(int[] arr, int n)
        {
            int[] dp = new int[n];

            for (int i = 0; i < n; i++)
            {
                dp[i] = arr[i];


                int maxi = 0;

                for (int j = 1; j < Math.Sqrt(i + 1); j++)
                {
                    if (((i + 1) % j == 0) && (i + 1) != j)
                    {
                        if (dp[j - 1] > maxi)
                        {
                            maxi = dp[j - 1];
                        }

                        if (dp[i + 1 / j - 1] > maxi && j != 1)
                        {
                            maxi = dp[(i + 1) / j - 1];
                        }
                    }
                }

                dp[i] += maxi;
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(dp[i] + " ");
            }
        }
    }
}
