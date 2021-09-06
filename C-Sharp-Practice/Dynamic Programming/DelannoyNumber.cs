using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class DelannoyNumber
    {
        int Dealnnoy(int n, int m)
        {
            if (m == 0 || n == 0)
            {
                return 1;
            }

            return Dealnnoy(m - 1, n) + Dealnnoy(m - 1, n - 1) + Dealnnoy(m, n - 1);
        }
    }
}
