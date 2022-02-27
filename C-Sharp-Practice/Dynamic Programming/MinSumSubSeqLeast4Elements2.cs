using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class MinSumSubSeqLeast4Elements2
    {
        int MinSum(int[] ar, int n)
        {
            if (n <= 4)
            {
                return ar.Min();
            }

            int[] sum = new int[n];
            sum[0] = ar[0];
            sum[1] = ar[1];
            sum[2] = ar[2];
            sum[3] = ar[3];

            int[] tempArr;

            for (int i = 4; i < n; i++)
            {
                tempArr = new int[4];
                Array.Copy(sum, i - 4, tempArr, 0, 4);
                sum[i] = ar[i] + tempArr.Min();
            }

            tempArr = new int[4];
            Array.Copy(sum, n - 4, tempArr, 0, 4);
            return tempArr.Min();
        }
    }
}
