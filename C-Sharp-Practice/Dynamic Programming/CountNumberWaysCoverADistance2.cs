using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class CountNumberWaysCoverADistance2
    {
        int Count(int dist)
        {
            int[] count = new int[dist + 1];

            count[0] = 1;
            count[1] = 1;
            count[2] = 2;

            for (int i = 3; i <= dist; i++)
            {
                count[i] = count[i - 1] + count[i - 2] + count[i - 3];
            }

            return count[dist];
        }
    }
}
