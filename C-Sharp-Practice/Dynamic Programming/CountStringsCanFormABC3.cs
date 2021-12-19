using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class CountStringsCanFormABC3
    {
        int CountStr(int n)
        {
            return 1 + (n * 2) + (n * ((n * n) - 1) / 2);
        }
    }
}
