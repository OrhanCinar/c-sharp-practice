using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class CountNumberWaysCoverADistance3
    {
        int CountDp(int dist)
        {
            int[] ways = new int[3];
            int n = dist;

            ways[0] = 1;
            ways[1] = 1;
            ways[2] = 2;


            for (int i = 3; i < n; i++)
            {
                ways[i % 3] = ways[(i - 1) % 3] + ways[(i - 2) % 3] + ways[(i - 3) % 3];
            }


            return ways[n % 3];
        }
    }
}
