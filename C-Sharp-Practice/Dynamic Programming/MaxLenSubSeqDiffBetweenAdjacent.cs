﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class MaxLenSubSeqDiffBetweenAdjacent
    {
        int MaxLenSub(int[] arr, int n)
        {
            int[] mls = new int[n];
            int max = 0;

            for (int i = 0; i < n; i++)
            {
                mls[i] = 1;
            }

            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (Math.Abs(arr[i] - arr[j]) <= 1 && mls[i] < mls[j] + 1)
                    {
                        mls[i] = mls[j] + 1;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (max < mls[i])
                {
                    max = mls[i];
                }
            }


            return max;
        }
    }
}
