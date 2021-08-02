using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class CountWaysToDivideCircle
    {
        int ChordCnt(int A)
        {
            int n = 2 * A;
            int[] dpArray = new int[n + 1];
            dpArray[0] = 1;
            dpArray[1] = 1;

            for (int i = 4; i <= n; i += 2)
            {
                for (int j = 0; j < i - 1; j += 2)
                {
                    dpArray[i] += (dpArray[j] * dpArray[i - 2 - j]);
                }
            }


            return dpArray[n];
        }
    }
}
