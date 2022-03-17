using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class FindLengthLongestSubSeqStrSubStr
    {
        int MaxSubsequenceSubString(string X, string Y, int n, int m)
        {
            if (n == 0 || m == 0)
            {
                return 0;
            }

            if (X[n - 1] == Y[m - 1])
            {
                return 1 + MaxSubsequenceSubString(X, Y, n - 1, m - 1);
            }
            else
            {
                return MaxSubsequenceSubString(X, Y, n - 1, m);
            }
        }
    }
}
