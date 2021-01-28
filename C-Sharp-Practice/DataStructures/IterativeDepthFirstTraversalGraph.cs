using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.DataStructures
{
    public class IterativeDepthFirstTraversalGraph
    {
        public int V;

        public LinkedList<int>[] adj;

        public IterativeDepthFirstTraversalGraph(int v)
        {
            V = v;
            adj = new LinkedList<int>[v];

            for (int i = 0; i < adj.Length; i++)
            {
                adj[i] = new LinkedList<int>();
            }            
        }

        public void AddEdge(int v, int w)
        {
            adj[v].AddLast(w);
        }

        public void DFS(int s)
        {
            bool[] visited = new bool[V];

            Stack<int> st = new Stack<int>();

            st.Push(s);

            while (st.Count > 0)
            {
                s = st.Peek();
                st.Pop();

                if (!visited[s])
                {
                    Console.Write(s + " ");
                    visited[s] = true;
                }

                foreach (var v in adj[s])
                {
                    if (visited[s])
                    {
                        st.Push(v);
                    }
                }
            }            
        }
    }

}
