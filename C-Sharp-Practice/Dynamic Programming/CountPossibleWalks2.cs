using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class CountPossibleWalks2
    {
        int V = 4;

        int Countwalks(int[,] graph, int u, int v, int k)
        {
            int[,,] count = new int[V, V, k + 1];

            for (int e = 0; e <= k; e++)
            {
                for (int i = 0; i < V; i++)
                {
                    for (int j = 0; j < V; j++)
                    {
                        count[i, j, e] = 0;

                        if (e == 0 && i == j)
                        {
                            count[i, j, e] = 1;
                        }

                        if (e == 1 && graph[i, j] != 0)
                        {
                            count[i, j, e] = 1;
                        }

                        if (e > 1)
                        {
                            for (int a = 0; a < V; a++)
                            {
                                if (graph[i, a] != 0)
                                {
                                    count[i, j, e] += count[a, j, e - 1];
                                }
                            }
                        }
                    }
                }
            }

            return count[u, v, k]; ;
        }
    }
}
