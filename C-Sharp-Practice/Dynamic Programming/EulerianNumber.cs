using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class EulerianNumber
    {
        int Eulerian(int n, int m)
        {
            if (m >= n || n == 0)
            {
                return 0;
            }

            if (m == 0)
            {
                return 1;
            }

            return (n - m) * Eulerian(n - 1, m - 1) + (m + 1) * Eulerian(n - 1, m);
        }
    }
}
