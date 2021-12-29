using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class MaximumProductCutting2
    {
        int MaxProd(int n)
        {
            int[] val = new int[n + 1];
            val[0] = val[1] = 0;

            for (int i = 1; i < n; i++)
            {
                int max_val = 0;

                for (int j = 0; j <= i; j++)
                {
                    max_val = Math.Max(max_val, Math.Max((i - j) * j, j * val[i - j]));
                }

                val[i] = max_val;
            }

            return val[n];
        }
    }
}
