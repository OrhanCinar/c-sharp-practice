using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class HosoyaTriangle
    {
        int Hosoya(int n, int m)
        {
            if ((n == 0 && m == 0) || (n == 1 && m == 0) || (n == 1 && m == 1) || (n == 2 && m == 1))
            {
                return 1;
            }

            if (n > m)
            {
                return Hosoya(n - 1, m) + Hosoya(n - 2, m);
            }
            else if (m == n)
            {
                return Hosoya(n - 1, m - 1) + Hosoya(n - 2, m - 2);
            }
            else
            {
                return 0;
            }

        }
    }
}
