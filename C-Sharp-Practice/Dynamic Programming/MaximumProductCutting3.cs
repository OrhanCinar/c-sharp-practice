using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class MaximumProductCutting3
    {
        int MaxProd(int n)
        {
            if (n == 0 | n == 1)
            {
                return 0;
            }

            int max_val = 0;

            for (int i = 1; i < n; i++)
            {
                max_val = Math.Max(max_val, Math.Max(i * (n - i), MaxProd(n - 1) * i));
            }

            return max_val;
        }
    }
}
