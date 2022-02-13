using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class MinNumSquareSumEqualsToN
    {
        int GetMinSquares(int n)
        {
            if (n <= 3)
            {
                return n;
            }

            int res = n;

            for (int x = 0; x <= n; x++)
            {
                int temp = x * x;
                if (temp > n)
                {
                    break;
                }
                else
                {
                    res = Math.Max(res, 1 + GetMinSquares(n - temp));
                }
            }

            return res;
        }
    }
}
