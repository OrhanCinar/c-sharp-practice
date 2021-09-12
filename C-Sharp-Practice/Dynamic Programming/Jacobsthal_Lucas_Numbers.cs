using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class Jacobsthal_Lucas_Numbers
    {
        int Jacobsthal(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            if (n == 1)
            {
                return 1;
            }

            return Jacobsthal(n - 1) + 2 * Jacobsthal(n - 2);
        }


        int Jacobsthal_Lucas(int n)
        {
            if (n == 0)
            {
                return 2;
            }

            if (n == 1)
            {
                return 1;
            }

            return Jacobsthal_Lucas(n - 1) + 2 * Jacobsthal_Lucas(n - 2);
        }
    }
}
