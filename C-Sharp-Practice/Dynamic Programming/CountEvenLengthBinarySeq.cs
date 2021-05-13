using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class CountEvenLengthBinarySeq
    {
        public int Count(int n, int diff)
        {
            if (Math.Abs(diff) > n)
            {
                return 0;
            }

            if (n == 1 && diff == 0)
            {
                return 2;
            }

            if (n == 1 && Math.Abs(diff) == 1)
            {
                return 1;
            }

            int res = Count(n - 1, diff + 1) + 2 * Count(n - 1, diff) + Count(n - 1, diff - 1);

            return res;
        }
    }
}
