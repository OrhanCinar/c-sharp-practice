using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class NumberOfDecimalNumOfLenghtK
    {
        int DP_s = 9;

        int GetNumStrictMonotone(int len)
        {
            int[,] DP = new int[len, DP_s];

            for (int i = 0; i < DP_s; ++i)
            {
                DP[0, i] = i + 1;
            }

            for (int i = 1; i < len; ++i)
            {
                for (int j = 1; j < DP_s; j++)
                {
                    DP[i, j] = DP[i - 1, j - 1] + DP[i, j - 1];
                }
            }

            return DP[len - 1, DP_s - 1];
        }
    }
}
