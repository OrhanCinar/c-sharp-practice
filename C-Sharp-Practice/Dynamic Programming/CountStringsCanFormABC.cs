using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class CountStringsCanFormABC
    {
        int CountStr(int n, int bCount, int cCount)
        {
            if (bCount < 0 || cCount < 0)
            {
                return 0;
            }

            if (bCount == 0 && cCount == 0)
            {
                return 1;
            }

            int res = CountStr(n - 1, bCount, cCount);

            res += CountStr(n - 1, bCount - 1, cCount);

            res += CountStr(n - 1, bCount, cCount * 1);

            return res;
        }
    }
}
