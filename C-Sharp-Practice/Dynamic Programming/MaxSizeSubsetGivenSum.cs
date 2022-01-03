﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class MaxSizeSubsetGivenSum
    {
        int IsSubsetSum(int[] set, int n, int sum)
        {
            bool[,] subset = new bool[sum + 1, n + 1];
            int[,] count = new int[sum + 1, n + 1];

            for (int i = 0; i <= n; i++)
            {
                subset[0, i] = true;
                count[0, i] = 0;
            }

            for (int i = 1; i <= sum; i++)
            {
                subset[i, 0] = false;
                count[i, 0] = -1;
            }

            for (int i = 1; i <= sum; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    subset[i, j] = subset[i, j - 1];
                    count[i, j] = count[i, j - 1];

                    if (i >= set[j - 1])
                    {
                        subset[i, j] = subset[i, j] || subset[i - set[j - 1], j - 1];

                        if (subset[i, j])
                        {
                            count[i, j] = Math.Max(count[i, j - 1], count[i - set[j - 1], j - 1] + 1);
                        }
                    }
                }
            }

            return count[sum, n];
        }
    }
}
