using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class LongestPalindromicSubsequence
    {
        int Lps(char[] seq, int i, int j)
        {
            if (i == j)
            {
                return 1;
            }

            if (seq[i] == seq[j] && i + 1 == j)
            {
                return 2;
            }

            if (seq[i] == seq[j])
            {
                return Lps(seq, i + 1, j - 1) + 2;
            }

            return Math.Max(Lps(seq, i, j - 1), Lps(seq, i + 1, j));
        }
    }
}
