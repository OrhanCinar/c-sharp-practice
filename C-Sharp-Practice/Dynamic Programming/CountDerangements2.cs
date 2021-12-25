using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class CountDerangements2
    {
        int CountDer(int n)
        {
            int[] der = new int[n + 1];

            der[1] = 0;
            der[2] = 1;

            for (int i = 3; i <= n; i++)
            {
                der[i] = (i - 1) * (der[i - 1] + der[i - 2]);
            }

            return der[n];
        }
    }
}
