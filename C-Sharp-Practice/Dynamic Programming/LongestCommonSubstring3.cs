using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class LongestCommonSubstring3
    {
        String X, Y;
        int Lcs(int i, int j, int count)
        {
            if (i == 0 || j == 0)
            {
                return count;
            }

            if (X[i - 1] == Y[j - 1])
            {
                count = Lcs(i - 1, j - 1, count + 1);
            }
            count = Math.Max(count, Math.Max(Lcs(i, j - 1, 0), Lcs(i - 1, j, 0)));

            return count;
        }
    }
}
