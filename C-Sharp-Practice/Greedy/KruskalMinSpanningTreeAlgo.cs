using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace C_Sharp_Practice.Greedy
{

    public class KruskalMinSpanningTreeAlgo
    {
        class Edge : IComparable<Edge>
        {
            public int src, dest, weight;

            public int CompareTo(Edge other)
            {
                return weight - other.weight;
            }
        }

        class Subset
        {
            public int parent, rank;
        }

        int V, E;
        Edge[] edge;

        public KruskalMinSpanningTreeAlgo(int v, int e)
        {
            V = v;
            E = e;

            edge = new Edge[E];

            for (int i = 0; i < e; i++)
            {
                edge[i] = new Edge();
            }
        }

        int Find(Subset[] subsets, int i)
        {
            if (subsets[i].parent != i)
            {
                subsets[i].parent = Find(subsets, subsets[i].parent);
            };

            return subsets[i].parent;
        }

        void Union(Subset[] subsets, int x, int y)
        {
            int xRoot = Find(subsets, x);
            int yRoot = Find(subsets, y);


            if (subsets[xRoot].rank < subsets[yRoot].rank)
            {
                subsets[xRoot].parent = yRoot;
            }
            else if (subsets[xRoot].rank > subsets[yRoot].rank)
            {
                subsets[yRoot].parent = xRoot;
            }
            else
            {
                subsets[yRoot].parent = xRoot;
                subsets[xRoot].rank++;
            }

        }

        void KruskalMST()
        {
            Edge[] result = new Edge[V];
            int e = 0;
            int i = 0;

            for (i = 0; i < V; i++)
            {
                result[i] = new Edge();
            }

            Array.Sort(edge);

            Subset[] subsets = new Subset[V];

            for (i = 0; i < V; i++)
            {
                subsets[i] = new Subset();
            }

            for (int v = 0; v < V; ++v)
            {
                subsets[v].parent = v;
                subsets[v].rank = 0;
            }

            i = 0;

            while (e < V - 1)
            {
                Edge next_edge = new Edge();
                next_edge = edge[i++];

                int x = Find(subsets, next_edge.src);
                int y = Find(subsets, next_edge.dest);

                if (x != y)
                {
                    result[e++] = next_edge;
                    Union(subsets, x, y);
                }
            }

            Console.WriteLine("Following are the edges in the constructed MST");

            int minimumCost = 0;
            for (i = 0; i < e; ++i)
            {
                Console.WriteLine($"{result[i].src} -- {result[i].dest} == {result[i].weight}");
                minimumCost += result[i].weight;
            }

            Console.WriteLine("Minimum Cost Spanning Tree"
                              + minimumCost);
            Console.ReadLine();
        }
    }
}
