using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class CountNumberBinaryStringWoConsecutive
    {
        int CountStrings(int n)
        {
            int[] a = new int[n];
            int[] b = new int[n];

            for (int i = 1; i < n; i++)
            {
                a[i] = a[i - 1] + b[i - 1];
                b[i] = a[i - 1];
            }

            return a[n - 1] + b[n - 1];
        }
    }
}
