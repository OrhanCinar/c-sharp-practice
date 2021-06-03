using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class MaxSumIncSubSeqPrefix2
    {
        int Compute(int[] a, int n, int index, int k)
        {
            if (index >= k)
            {
                return -1;
            }

            int[] dp = new int[index + 1];
            int i;

            for (i = 0; i <= index; i++)
            {
                dp[i] = a[i];
            }

            int maxi = int.MinValue;

            for (i = 0; i <= index; i++)
            {
                if (a[i] >= a[k])
                {
                    continue;
                }

                for (int j = 0; j < i; j++)
                {
                    if (a[i] > a[j])
                    {
                        dp[i] = dp[j] + a[i];
                    }

                    maxi = Math.Max(maxi, dp[i]);
                }
            }

            if (maxi == int.MinValue)
            {
                return a[k];
            }

            return maxi + a[k];
        }
    }
}
