using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class ClusterArraySumSquare
    {
        int inf = 1000000000;
        int ans = 1000000000;

        void Solve(int i, int par, int[] a, int n, int k, int current_ans)
        {
            if (par > k)
            {
                return;
            }

            if (par == k && i == n - 1)
            {
                ans = Math.Min(ans, current_ans);
                return;
            }

            for (int j = i + 1; j < n; j++)
            {
                Solve(j, par + 1, a, n, k, current_ans + (a[j] - a[i + 1]) * (a[j] - a[i + 1]));
            }
        }
    }
}
