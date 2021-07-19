using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class CountWaysReachToNthStair2
    {
        int CountWays(int n)
        {
            int[] res = new int[n + 2];
            res[0] = 1;
            res[1] = 1;
            res[2] = 2;

            for (int i = 3; i <= n; i++)
            {
                res[i] = res[i - 1] + res[i - 2] + res[i - 3];
            }


            return res[n];
        }
    }
}
