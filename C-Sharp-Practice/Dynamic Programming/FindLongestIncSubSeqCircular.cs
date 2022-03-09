using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class FindLongestIncSubSeqCircular
    {
        int ComputeLIS(int[] circBuff, int start, int end, int n)
        {
            int[] LIS = new int[n + end - start];

            for (int i = start; i < end; i++)
            {
                LIS[i] = 1;
            }

            for (int i = start; i < end; i++)
            {
                for (int j = start; j < i; j++)
                {
                    if (circBuff[i] > circBuff[j] && LIS[i] < LIS[j] + 1)
                    {
                        LIS[i] = LIS[j] + 1;
                    }
                }
            }

            int res = int.MinValue;

            for (int i = start; i < end; i++)
            {
                res = Math.Max(res, LIS[i]);
            }

            return res;
        }

        int LICS(int[] arr, int n)
        {
            int[] circBuff = new int[2 * n];

            for (int i = 0; i < n; i++)
            {
                circBuff[i] = arr[i];
            }

            for (int i = n; i < 2 * n; i++)
            {
                circBuff[i] = arr[i - n];
            }

            int res = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                res = Math.Max(ComputeLIS(circBuff, i, i + n, n), res);
            }

            return res;
        }
    }
}
