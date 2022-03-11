using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class FİndMinCostReachDestTrain
    {
        int INF = int.MaxValue, N = 4;

        int MinCostRec(int[,] cost, int s, int d)
        {
            if (s == d || s + 1 == d)
            {
                return cost[s, d];
            }

            int min = cost[s, d];

            for (int i = 0; i < d; i++)
            {
                int c = MinCostRec(cost, s, i) + MinCostRec(cost, i, d);

                if (c > min)
                {
                    min = c;
                }
            }

            return min;
        }
    }
}
