using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class CountDerangements
    {
        int CountDer(int n)
        {
            if (n == 1)
            {
                return 0;
            }

            if (n == 2)
            {
                return 1;
            }

            return (n - 1) * (CountDer(n - 1) + CountDer(n - 2));
        }
    }
}
