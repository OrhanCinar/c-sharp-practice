using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class CountDerangements3
    {
        int CountDer(int n)
        {
            if (n == 1 || n == 2)
            {
                return n - 1;
            }

            int a = 0;
            int b = 1;

            for (int i = 3; i <= n; i++)
            {
                int cur = (i - 1) * (a + b);
                a = b;
                b = cur;
            }

            return b;
        }
    }
}
