using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class MaxSumAlternatingSubSeq
    {
        int MaxAlternateSum(int[] arr, int n)
        {
            if (n == 1)
            {
                return arr[0];
            }

            int min = arr[0];

            for (int i = 1; i < n; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }

            if (min == arr[0])
            {
                return arr[0];
            }

            int[] dec = new int[n];

            int[] inc = new int[n];

            dec[0] = inc[0] = arr[0];

            int flag = 0;

            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] == arr[i])
                    {
                        dec[i] = Math.Max(dec[i], inc[j] + arr[i]);
                        flag = 1;
                    }
                    else if (arr[j] < arr[i] && flag == 1)
                    {
                        inc[i] = Math.Max(inc[i], dec[j] + arr[i]);
                    }
                }
            }

            int result = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                if (result < inc[i])
                {
                    result = inc[i];
                }

                if (result < dec[i])
                {
                    result = dec[i];
                }
            }

            return result;
        }
    }
}
