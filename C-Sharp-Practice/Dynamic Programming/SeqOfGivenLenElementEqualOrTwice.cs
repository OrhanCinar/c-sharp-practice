using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class SeqOfGivenLenElementEqualOrTwice
    {
        public int getTotalSequence(int m, int n)
        {
            if (m < n)
            {
                return 0;
            }

            if (n == 0)
            {
                return 1;
            }

            return getTotalSequence(m - 1, n) + getTotalSequence(m / 2, n - 1);
        }
    }
}
