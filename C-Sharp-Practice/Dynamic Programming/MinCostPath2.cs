using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    public class MinCostPath2
    {
        private int Min(int x, int y, int z)
        {
            if (x < y)
            {
                return x < z ? x : z;
            }

            return y < z ? y : z;
        }

        public int MinCost(int[,] cost, int m, int n)
        {
            int i, j;
            int[,] tc = new int[m + 1, n + 1];

            tc[0, 0] = cost[0, 0];

            for (i = 1; i <= m; i++)
            {
                tc[i, 0] = tc[i - 1, 0] + cost[i, 0];
            }

            for (j = 1; j <= n; j++)
            {
                tc[0, j] = tc[0, j - 1] + cost[0, j];
            }


            for (i = 1; i <= m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    tc[i, j] = Min(tc[i - 1, j - 1], tc[i - 1, j], tc[i, j - 1]) + cost[i, j];
                }
            }

            return tc[m, n];
        }
    }
}
