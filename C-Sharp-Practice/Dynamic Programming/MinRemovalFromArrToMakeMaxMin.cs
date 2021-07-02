using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class MinRemovalFromArrToMakeMaxMin
    {
        int MAX = 100;
        int[,] dp = new int[100, 100];

        int CountRemovals(int[] a, int i, int j, int k)
        {

            if (i >= j)
            {
                return 0;
            }
            else if ((a[j] - a[i]) <= k)
            {
                return 0;
            }
            else if (dp[i, j] != -1)
            {
                return dp[i, j];
            }
            else if ((a[j] - a[i] > k))
            {
                dp[i, j] = 1 + Math.Min(CountRemovals(a, i + 1, j, k), CountRemovals(a, i, j - 1, k));
            }


            return dp[i, j];
        }

        int Removals(int[] a, int n, int k)
        {
            Array.Sort(a);
            
            for (int i = 0; i < MAX; i++)
            {
                for (int j = 0; j < MAX; j++)
                    dp[i, j] = -1;
            }
            if (n == 1)
            {
                return 0;
            }
            else
            {
                return CountRemovals(a, 0,n - 1, k);
            }
        }
    }
}
