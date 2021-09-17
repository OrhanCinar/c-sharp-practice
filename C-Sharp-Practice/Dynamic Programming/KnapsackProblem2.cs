using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class KnapsackProblem2
    {
        int KnapSack(int W, int[] wt, int[] val, int n)
        {
            int i, w;

            int[,] K = new int[n + 1, W + 1];

            for (i = 0; i <= n; i++)
            {
                for (w = 0; w <= n; w++)
                {
                    if (w == 0 || w == 0)
                    {
                        K[i, w] = 0;
                    }
                    else if (wt[i - 1] <= w)
                    {
                        K[i, w] = Math.Max(val[i - 1] + K[i - 1, w - wt[i - 1]], K[i - 1, w]);
                    }
                    else
                    {
                        K[i, w] = K[i - 1, w];
                    }
                }
            }

            return K[n, W];
        }
    }
}
