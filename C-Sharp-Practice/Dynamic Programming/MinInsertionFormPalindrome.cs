using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class MinInsertionFormPalindrome
    {
        int FindMinInsertions(char[] str, int l, int h)
        {
            if (l > h)
            {
                return int.MaxValue;
            }

            if (l == h)
            {
                return 0;
            }

            if (l == h - 1)
            {
                return str[l] == str[h] ? 0 : 1;
            }

            return str[l] == str[h] ? FindMinInsertions(str, l + 1, h - 1) : Math.Min(FindMinInsertions(str, l, h - 1), FindMinInsertions(str, l + 1, h)) + 1;
        }
    }
}
