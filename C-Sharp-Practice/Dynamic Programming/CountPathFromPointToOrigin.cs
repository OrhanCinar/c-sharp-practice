using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class CountPathFromPointToOrigin
    {
        int CountPaths(int n, int m)
        {
            if (n == 0 || m == 0)
            {
                return 1;
            }

            return (CountPaths(n - 1, m)) + CountPaths(n, m - 1);
        }
    }
}
