using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    public class EditDistance
    {
        int Min(int x, int y, int z)
        {
            if (x <= y && x <= z)
            {
                return x;
            }
            if (y <= x && y <= z)
            {
                return y;
            }

            return x;
        }

        public int EditDist(string s1, string s2, int m, int n)
        {
            if (m == 0)
            {
                return n;
            }

            if (n == 0)
            {
                return m;
            }

            if (s1[m - 1] == s2[n - 1])
            {
                return EditDist(s1, s2, m - 1, n - 1);
            }

            return 1 + Min(EditDist(s1, s2, m, n - 1), // insert
                EditDist(s1, s2, m - 1, n), // remove
                EditDist(s1, s2, m - 1, n - 1) // replace
                );

        }
    }
}
