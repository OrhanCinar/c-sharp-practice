using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class CountPersonPair
    {
        int NumberOfWays(int x)
        {
            if (x == 0 || x == 1)
            {
                return 1;
            }
            else
            {
                return NumberOfWays(x - 1) + (x - 1) * NumberOfWays(x - 2);
            }
        }
    }
}
