using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class FindMaxPossibleStolenValueHouse2
    {
        int MaxLoot(int[] hval, int n)
        {
            if (n == 0)
            {
                return 0;
            }


            int value1 = hval[0];

            if (n == 1)
            {
                return value1;
            }

            int value2 = Math.Max(hval[0], hval[1]);

            if (n == 2)
            {
                return value2;
            }

            int max_val = 0;

            for (int i = 2; i < n; i++)
            {
                max_val = Math.Max(hval[i] + value1, value2);
                value1 = value2;
                value2 = max_val;
            }


            return max_val;
        }
    }
}
