using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class RecursiveBreakNumber3MaxSum
    {
        int BreakSum(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }


            return Math.Max((BreakSum(n / 2) + BreakSum(n / 3) + BreakSum(n / 4)), n);
        }
    }
}
