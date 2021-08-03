using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class CountWaysTileFloor
    {
        int CountWays(int n, int m)
        {
            int[] count = new int[n + 1];
            count[0] = 0;
            int i;


            for (i = 1; i <= n; i++)
            {
                if (i > m)
                {
                    count[i] = count[i - 1] + count[i - m];
                }
                else if (i < m || i == 1)
                {
                    count[i] = 1;
                }
                else
                {
                    count[i] = 2;
                }
            }


            return count[n];
        }
    }
}
