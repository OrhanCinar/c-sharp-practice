using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class FİndMinCostReachDestTrain2
    {
        int INF = int.MaxValue, N = 4;

        int MinCost(int[,] cost)
        {
            int[] dist = new int[N];

            for (int i = 0; i < N; i++)
            {
                dist[i] = INF;
            }

            dist[0] = 0;

            for (int i = 0; i < N; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    if (dist[j] > dist[i] + cost[i, j])
                    {
                        dist[j] = dist[i] + cost[i, j];
                    }
                }
            }

            return dist[N - 1];
        }
    }
}
