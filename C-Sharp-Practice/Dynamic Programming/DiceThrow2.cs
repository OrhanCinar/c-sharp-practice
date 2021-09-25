using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class DiceThrow2
    {
        long FindWays(int f, int d, int s)
        {
            long[,] mem = new long[d + 1, s + 1];

            mem[0, 0] = 1;

            for (int i = 1; i <= d; i++)
            {
                for (int j = i; j <= s; j++)
                {
                    mem[i, j] = mem[i, j - 1] + mem[i - 1, j - 1];

                    if (j - f - 1 >= 0)
                    {
                        mem[i, j] -= mem[i - 1, j - f - 1];
                    }
                }
            }

            return mem[d, s];
        }
    }
}
