using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class MaxSum2xnGrid
    {
        int MaxSum(int[,] grid, int n)
        {
            int incl = Math.Max(grid[0, 0], grid[1, 0]);

            int excl = 0, excl_new;

            for (int i = 1; i < n; i++)
            {
                excl_new = Math.Max(excl, incl);

                incl = excl + Math.Max(grid[0, i], grid[1, i]);

                excl = excl_new;
            }

            return Math.Max(excl, incl);
        }
    }
}
