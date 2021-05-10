using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class NewmanConwaySequence2
    {
        public int Sequence(int n)
        {
            int[] f = new int[n + 1];

            f[0] = 0;
            f[1] = 1;
            f[2] = 1;

            int i;

            for (i = 3; i <= n; i++)
            {
                f[i] = f[f[i - 1]] + f[i - f[i - 1]];
            }

            return f[n];
        }
    }
}
