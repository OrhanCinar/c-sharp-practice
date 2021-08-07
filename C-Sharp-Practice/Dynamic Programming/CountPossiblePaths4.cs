using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class CountPossiblePaths4
    {
        int NumberOfPaths(int m, int n)
        {
            int path = 1;

            for (int i = 1; i < m + n - 1; i++)
            {
                path *= i;
                path /= i - n + 1;
            }

            return path;
        }
    }
}
