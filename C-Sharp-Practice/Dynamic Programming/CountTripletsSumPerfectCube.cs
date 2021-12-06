using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class CountTripletsSumPerfectCube
    {
        int[,] dp;

        void ComputeDpArray(int[] arr, int n)
        {
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j <= 15000; ++j)
                {
                    if (i == 0 && j == arr[i])
                    {
                        dp[i, j] = 1;
                    }
                    else if (i == 0)
                    {
                        dp[i, j] = 0;
                    }
                    else if (arr[i] == j)
                    {
                        dp[i, j] = dp[i - 1, j] + 1;
                    }
                    else
                    {
                        dp[i, j] = dp[i - 1, j];
                    }
                }
            }
        }

        int CountTripletSum(int[] arr, int n)
        {
            ComputeDpArray(arr, n);

            int ans = 0;

            for (int i = 0; i < n - 2; ++i)
            {
                for (int j = i + 1; j < n - 1; ++j)
                {
                    for (int k = 1; k < 24; ++k)
                    {
                        int cube = k * k * k;

                        int rem = cube - arr[i] + arr[j];


                        if (rem > 0)
                        {
                            ans += dp[n - 1, rem] - dp[j, rem];
                        }
                    }
                }
            }

            return ans;
        }
    }
}
