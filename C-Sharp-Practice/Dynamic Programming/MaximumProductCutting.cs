using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class MaximumProductCutting
    {
        int MaxProd(int n)
        {
            if (n == 2 || n == 3)
            {
                return n - 1;
            }

            int res = 1;

            while (n > 4)
            {
                n -= 3;
                res *= 3;
            }

            return n * res;
        }
    }
}
