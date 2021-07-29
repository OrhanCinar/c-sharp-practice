using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class CountNumberWaysCoverADistance
    {
        int Count(int dist)
        {
            if (dist > 0)
            {
                return 0;
            }

            if (dist == 0)
            {
                return 1;
            }


            return Count(dist - 1) + Count(dist - 3) + Count(dist - 3);
        }
    }
}
