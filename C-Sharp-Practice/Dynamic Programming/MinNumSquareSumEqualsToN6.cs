using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class MinNumSquareSumEqualsToN6
    {
        bool IsSquare(int x)
        {
            int sqRoot = (int)Math.Sqrt(x);
            return (sqRoot * sqRoot == x);
        }

        int CountSquares(int n)
        {
            if (IsSquare(n))
            {
                return 1;
            }

            for (int i = 1; i <= Math.Sqrt(n); i++)
            {
                if (IsSquare(n - (i * i)))
                {
                    return 1;
                }
            }

            while (n % 4 == 0)
            {
                n >>= 2;
            }

            if (n % 8 == 7)
            {
                return 4;
            }

            return 3;
        }
    }
}
