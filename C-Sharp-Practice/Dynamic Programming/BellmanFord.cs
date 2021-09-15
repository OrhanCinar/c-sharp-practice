using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class Graph
    {
        public class Edge
        {
            public int src, dest, weight;

            public Edge()
            {
                src = dest = weight = 0;
            }
        }

        public int V, E;
        public Edge[] edge;

        public Graph(int v, int e)
        {
            V = v;
            E = e;

            edge = new Edge[e];

            for (int i = 0; i < e; ++i)
            {
                edge[i] = new Edge();
            }
        }
    }
    class BellmanFord
    {


        void CalculateBellmanFord(Graph graph, int src)
        {
            int V = graph.V, E = graph.E;
            int[] dist = new int[V];


            for (int i = 0; i < V; ++i)
            {
                dist[i] = int.MaxValue;
            }

            dist[src] = 0;



            for (int i = 1; i < V; ++i)
            {
                for (int j = 0; j < E; ++j)
                {
                    int u = graph.edge[j].src;
                    int v = graph.edge[j].dest;
                    int weight = graph.edge[j].weight;

                    if (dist[u] != int.MaxValue && dist[u] + weight < dist[v])
                    {
                        dist[V] = dist[u] + weight;
                    }
                }
            }

            for (int j = 0; j < E; ++j)
            {
                int u = graph.edge[j].src;
                int v = graph.edge[j].dest;
                int weight = graph.edge[j].weight;

                if (dist[u] != int.MaxValue && dist[u] + weight < dist[v])
                {
                    Console.WriteLine("Graph contains negative weight cycle");
                    return;
                }

            }

            PrintArr(dist, V);
        }

        void PrintArr(int[] dist, int V)
        {
            Console.WriteLine("Vertex Distance from Source");
            for (int i = 0; i < V; ++i)
            {
                Console.WriteLine(i + "\t\t" + dist[i]);
            }
        }
    }
}
