using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class FindNumberOfTimesStrSubSeq2
    {
        int Count(String a, String b)
        {
            int m = a.Length;
            int n = b.Length;

            int[,] lookup = new int[m + 1, n + 1];

            for (int i = 0; i <= n; ++i)
            {
                lookup[0, i] = 0;
            }

            for (int i = 0; i <= m; ++i)
            {
                lookup[i, 0] = 1;
            }

            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (a[i - 1] == b[j - 1])
                    {
                        lookup[i, j] = lookup[i - 1, j - 1] + lookup[i - 1, j];
                    }
                    else
                    {
                        lookup[i, j] = lookup[i - 1, j];
                    }
                }
            }

            return lookup[m, n];
        }
    }
}
