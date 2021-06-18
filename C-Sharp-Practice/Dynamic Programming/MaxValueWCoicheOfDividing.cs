using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class MaxValueWCoicheOfDividing
    {
        int MaxDp(int n)
        {
            int[] res = new int[n + 1];
            res[0] = 0;
            res[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                res[i] = Math.Max(i, (res[i / 2] + res[i / 3] + res[i / 4] + res[i / 5]));
            }

            return res[n];
        }
    }
}
