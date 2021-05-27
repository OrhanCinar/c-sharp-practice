using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class MaxProductIncSubSeq
    {
        long Lis(long[] arr, long n)
        {
            long[] mpis = new long[n];

            for (int i = 0; i < n; i++)
            {
                mpis[i] = arr[i];
            }

            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] > arr[j] && mpis[i] < (mpis[j] * arr[i]))
                    {
                        mpis[i] = mpis[j] * arr[i];
                    }
                }
            }


            return mpis.Max();
        }
    }
}
