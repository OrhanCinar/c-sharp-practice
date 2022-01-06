using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class MaxAvgSUmPartitionArray
    {
        int MAX = 1000;
        double[,] memo;

        public MaxAvgSUmPartitionArray()
        {
            memo = new double[MAX, MAX];
        }


        double Score(int n, List<int> A, int k)
        {
            if (memo[n, k] > 0)
            {
                return memo[n, k];
            }

            double sum = 0;

            for (int i = n - 1; i > 0; i--)
            {
                sum += A[i];

                memo[n, k] = Math.Max(memo[n, k], Score(i, A, k - 1) + sum / (n - i));
            }

            return memo[n, k];
        }

        double LargestSumOfAverages(List<int> A, int K)
        {
            int n = A.Count;
            double sum = 0;

            for (int i = 0; i < memo.GetLength(0); i++)
            {
                for (int j = 0; j < memo.GetLength(1); j++)
                {
                    memo[i, j] = 0.0;
                }
            }

            for (int i = 0; i < n; i++)
            {
                sum += A[i];
                memo[i + 1, 1] = sum / (i + 1);
            }

            return Score(n, A, K);
        }
    }
}
