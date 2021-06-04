using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class MaxLenChainPairs
    {
        internal class Pair
        {
            public int a;
            public int b;

            public Pair(int a, int b)
            {
                this.a = a;
                this.b = b;
            }
        }

        int MaxChainLength(Pair[] arr, int n)
        {
            int i, j, max = 0;
            int[] mcl = new int[n];

            for (i = 0; i < n; i++)
            {
                mcl[i] = 1;
            }

            for (i = 1; i < n; i++)
            {
                for (j = 0; j < i; j++)
                {
                    if (arr[i].a > arr[j].b && mcl[i] < mcl[j] + 1)
                    {
                        mcl[i] = mcl[j] + 1;
                    }
                }
            }

            for (i = 0; i < n; i++)
            {
                if (max < mcl[i])
                {
                    max = mcl[i];
                }
            }

            return max;
        }
    }
}
