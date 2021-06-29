using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class MinCostFillWeightBag
    {
        int MinimumCost(int[] cost, int n, int W)
        {
            List<int> val = new List<int>();
            List<int> wt = new List<int>();

            int size = 0;

            for (int i = 0; i < n; i++)
            {
                if (cost[i] != -1)
                {
                    val.Add(cost[i]);
                    wt.Add(i + 1);
                    size++;
                }
            }

            n = size;

            int[,] min_cost = new int[n + 1, W + 1];

            for (int i = 0; i <= W; i++)
            {
                min_cost[0, i] = int.MaxValue;
            }

            for (int i = 1; i <= n; i++)
            {
                min_cost[i, 0] = 0;
            }

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= W; j++)
                {
                    if (wt[i - 1] > j)
                    {
                        min_cost[i, j] = min_cost[i - 1, j];
                    }
                    else
                    {
                        min_cost[i, j] = Math.Min(min_cost[i - 1, j], min_cost[i, j - wt[i - 1]] + val[i - 1]);
                    }
                }
            }

            return (min_cost[n, W] == int.MaxValue) ? -1 : min_cost[n, W];
        }
    }
}
