using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class KnapsackProblem
    {
        int KnapSack(int W, int[] wt, int[] val, int n)
        {

            if (n == 0 || W == 0)
            {
                return 0;
            }

            if (wt[n - 1] > W)
            {
                return KnapSack(W, wt, val, n - 1);
            }
            else
            {
                return Math.Max(val[n - 1] + KnapSack(W - wt[n - 1], wt, val, n - 1), KnapSack(W, wt, val, n - 1));
            }
        }
    }
}
