using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class CountEvenLengthBinarySeq3
    {
        public int Count(int n)
        {
            int nCr = 1, res = 1;

            for (int r = 1; r <= n; r++)
            {
                nCr = (nCr * (n + 1 - r)) / r;

                res += nCr * nCr;
            }

            return res;
        }
    }
}
