using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Greedy
{
    public class DijkstraShortestPath
    {
        int V = 9;

        private int MinDistance(int[] dist, bool[] sptSet)
        {
            int min = int.MinValue, min_index = -1;

            for (int v = 0; v < V; v++)
            {
                if (!sptSet[v] && dist[v] <= min)
                {
                    min = dist[v];
                    min_index = v;
                }
            }

            return min_index;
        }

        void PrintSolution(int[] dist)
        {
            Console.Write("Vertex \t\t Distance from Source\n");

            for (int i = 0; i < V; i++)
            {
                Console.Write(i + " \t\t " + dist[i] + "\n");
            }
        }

        void Dijkstra(int[,] graph, int src)
        {
            int[] dist = new int[V];

            bool[] sptSet = new bool[V];

            for (int i = 0; i < V; i++)
            {
                dist[i] = int.MaxValue;
                sptSet[i] = false;
            }

            dist[src] = 0;

            for (int count = 0; count < V; count++)
            {
                int u = MinDistance(dist, sptSet);

                sptSet[u] = true;

                for (int v = 0; v < V; v++)
                {
                    if (!sptSet[v] && graph[u,v] != 0 && dist[u] != int.MaxValue && dist[u] + graph[u,v]< dist[v])
                    {
                        dist[v] = dist[u] + graph[u, v];
                    }
                }
            }

            PrintSolution(dist);
        }
    }
}
