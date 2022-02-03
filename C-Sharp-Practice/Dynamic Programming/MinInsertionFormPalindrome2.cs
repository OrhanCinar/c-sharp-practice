using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class MinInsertionFormPalindrome2
    {
        int FindMinInsertionsDP(char[] str, int n)
        {
            int[,] table = new int[n, n];
            int l, h, gap;

            for (gap = 0; gap < n; ++gap)
            {
                for (l = 0, h = gap; l < n; ++l, ++h)
                {
                    table[l, h] = str[l] == str[h] ? table[l + 1, h - 1] : Math.Min(table[l, h - 1], table[l + 1, h]) + 1;
                }
            }

            return table[0, n - 1];
        }
    }
}
