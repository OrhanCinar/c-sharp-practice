using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class EntringerNumber
    {
        int Zigzag(int n, int k)
        {
            if (n == 0 && k == 0)
            {
                return 1;
            }

            if (k == 0)
            {
                return 0;
            }

            return Zigzag(n, k - 1) + Zigzag(n - 1, n - k);
        }
    }
}
