using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class FloydWarshall
    {
        int INF = 99999, V = 4;

        void FindFloydWarshall(int[,] graph)
        {
            int[,] dist = new int[V, V];
            int i, j, k;


            for (i = 0; i < V; i++)
            {
                for (j = 0; j < V; j++)
                {
                    dist[i, j] = graph[i, j];
                }
            }

            for (k = 0; k < V; k++)
            {
                for (i = 0; i < V; i++)
                {
                    for (j = 0; j < V; j++)
                    {
                        if (dist[i, k] + dist[k, j] < dist[i, j])
                        {
                            dist[i, j] = dist[i, k] + dist[k, j];
                        }
                    }
                }
            }

            PrintSolution(dist);
        }

        void PrintSolution(int[,] dist)
        {
            Console.WriteLine("Following matrix shows the shortest " +
                            "distances between every pair of vertices");
            for (int i = 0; i < V; ++i)
            {
                for (int j = 0; j < V; ++j)
                {
                    if (dist[i, j] == INF)
                    {
                        Console.Write("INF ");
                    }
                    else
                    {
                        Console.Write(dist[i, j] + " ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
