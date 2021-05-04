using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class AssemblyLineScheduling2
    {
        public int CanAssemblyTime(int[,] a, int[,] t, int[] e, int[] x)
        {
            int n = a.GetLength(1);

            int first = e[0] + a[0, 0];

            int second = e[1] + a[1, 0];

            for (int i = 1; i < n; i++)
            {
                int up = Math.Min(first + a[0, i], second + t[1, i] + a[0, i]);
                int down = Math.Min(second + a[1, i], first + t[0, i] + a[1, i]);

                first = up;
                second = down;
            }

            first += x[0];
            second += x[1];

            return Math.Min(first, second);
        }
    }
}
