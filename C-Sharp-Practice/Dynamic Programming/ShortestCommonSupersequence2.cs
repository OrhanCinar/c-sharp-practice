using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class ShortestCommonSupersequence2
    {
        int SuperSeq(String X, String Y, int m, int n)
        {
            if (m == 0)
            {
                return n;
            }

            if (n == 0)
            {
                return m;
            }

            if (X[m - 1] == Y[n - 1])
            {
                return 1 + SuperSeq(X, Y, m - 1, n - 1);
            }

            return 1 + Math.Max(SuperSeq(X, Y, m - 1, n), SuperSeq(X, Y, m, n - 1));
        }
    }
}
