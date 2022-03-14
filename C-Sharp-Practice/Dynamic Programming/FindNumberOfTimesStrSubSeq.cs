using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class FindNumberOfTimesStrSubSeq
    {
        int Count(string a, string b, int m, int n)
        {
            if ((m == 0 && n == 0) || n == 0)
            {
                return 1;
            }

            if (m == 0)
            {
                return 0;
            }

            if (a[m - 1] == b[n - 1])
            {
                return Count(a, b, m - 1, n - 1) + Count(a, b, m - 1, n);
            }
            else
            {
                return Count(a, b, m - 1, n);
            }
        }
    }
}
