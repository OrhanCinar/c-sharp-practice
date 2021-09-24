using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class DiceThrow
    {
        int FindWays(int m, int n, int x)
        {
            int[,] table = new int[n + 1, x + 1];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    table[i, j] = 0;
                }
            }

            for (int j = 0; j < m && j <= x; j++)
            {
                table[1, j] = 1;
            }

            for (int i = 2; i <= n; i++)
            {
                for (int j = 1; j <= x; j++)
                {
                    for (int k = 1; k <= m && k < j; k++)
                    {
                        table[i, j] += table[i - 1, j - k];
                    }
                }
            }

            return table[n, x];
        }
    }
}
