using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    public class MinCostPath3
    {
        int row = 3;
        int col = 3;

        private int MinCost(int[,] cost)
        {
            for (int i = 0; i < row; i++)
            {
                cost[i, 0] += cost[i - 1, 0];
            }

            for (int j = 0; j < col; j++)
            {
                cost[0, j] += cost[0, j - 1];
            }

            for (int i = 1; i < row; i++)
            {
                for (int j = 1; j < col; j++)
                {
                    cost[i, j] += Math.Min(cost[i - 1, j - 1],
                        Math.Min(cost[i - 1, j], cost[i, j - 1]));
                }
            }

            return cost[row - 1, col - 1];
        }
    }
}
