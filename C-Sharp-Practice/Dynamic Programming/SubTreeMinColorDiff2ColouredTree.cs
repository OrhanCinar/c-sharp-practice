using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class SubTreeMinColorDiff2ColouredTree
    {
        void Dfs(int node, int parent, List<int>[] tree, int[] colour, int[] answer)
        {
            answer[node] = colour[node];

            foreach (var u in tree[node])
            {
                if (u == parent)
                {
                    continue;
                }

                Dfs(u, node, tree, colour, answer);

                answer[node] += Math.Max(answer[u], 0);
            }
        }

        int MaxDiff(List<int>[] tree, int[] colour, int N)
        {
            int[] answer = new int[N + 1];

            Dfs(1, 0, tree, colour, answer);

            int high = 0;

            for (int i = 0; i <= N; i++)
            {
                high = Math.Max(high, answer[i]);

                answer[i] = 0;
            }

            for (int i = 1; i <= N; i++)
            {
                if (colour[i] == -1)
                {
                    colour[i] = 1;
                }
                else
                {
                    colour[i] = -1;
                }
            }

            Dfs(1, 0, tree, colour, answer);

            for (int i = 1; i < N; i++)
            {
                high = Math.Max(high, answer[i]);
            }

            return high;
        }
    }
}
