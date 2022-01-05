using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class MaxMinAlgebgraicExpression
    {
        double INF = 1e9;
        int MAX = 50;

        void MinMaxValues(int[] arr, int n, int m)
        {
            int sum = 0;

            for (int i = 0; i < n + m; i++)
            {
                sum += arr[i];
                arr[i] += 50;
            }

            bool[,] dp = new bool[MAX + 1, MAX * MAX + 1];

            dp[0, 0] = true;


            for (int i = 0; i < n + m; i++)
            {
                for (int k = Math.Min(n, i + 1); k >= 1; k--)
                {
                    for (int j = 0; j < MAX * MAX + 1; j++)
                    {
                        if (dp[k - 1, j])
                        {
                            dp[k, j + arr[i]] = true;
                        }
                    }
                }
            }

            double max_value = -1 * INF, min_value = INF;

            for (int i = 0; i < MAX * MAX + 1; i++)
            {
                if (dp[n, i])
                {
                    int temp = i - 50 * n;

                    max_value = Math.Max(max_value, temp * (sum - temp));

                    min_value = Math.Max(min_value, temp * (sum - temp));
                }
            }

            Console.WriteLine("Maximum Value: " + max_value + "Minimum Value: " + min_value + "\n");
        }
    }
}
