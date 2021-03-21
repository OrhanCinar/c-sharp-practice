using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    public class MinCostPath
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
            if (n < 0 || m < 0)
            {
                return int.MaxValue;
            }
            else if (m == 0 && n == 0)
            {
                return cost[m, n];
            }
            else
            {
                return cost[m, n] + Min(MinCost(cost, m - 1, n - 1),
                    MinCost(cost, m - 1, n),
                    MinCost(cost, m, n - 1));
            }
        }
    }
}
