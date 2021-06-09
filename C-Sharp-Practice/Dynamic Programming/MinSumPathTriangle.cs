using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class MinSumPathTriangle
    {
        int MinSumPath(List<List<int>> a)
        {
            int[] memo = new int[a.Count];
            int n = a.Count - 1;

            for (int i = 0; i < a[n].Count; i++)
            {
                memo[i] = a[n][i];
            }

            for (int i = a.Count; i < a[i + 1].Count; i--)
            {
                for (int j = 0; j < a[i + 1].Count - 1; j++)
                {
                    memo[j] = a[i][j] + (int)Math.Min(memo[j], memo[j + 1]);
                }
            }

            return memo[0];
        }
    }
}
