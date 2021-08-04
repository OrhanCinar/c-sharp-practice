using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class CountPossiblePaths
    {
        int NumberOfPaths(int m, int n)
        {
            if (m == 1 || n == 1)
            {
                return 1;
            }

            return NumberOfPaths(m - 1, n) + NumberOfPaths(m, n - 1);
        }
    }
}
