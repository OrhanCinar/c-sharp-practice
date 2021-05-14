using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class CountEvenLengthBinarySeq2
    {
        int[,] lookup = new int[1000, 1000];

        public int Count(int n, int diff)
        {
            if (Math.Abs(diff) > n)
            {
                return 0;
            }

            if (n == 1 && diff == 0)
            {
                return 2;
            }

            if (n == 1 && Math.Abs(diff) == 1)
            {
                return 1;
            }

            if (lookup[n, n+diff] != -1)
            {
                return lookup[n, n + diff];
            }


            int res = Count(n - 1, diff + 1) + 2 * Count(n - 1, diff + 1) + Count(n - 1, diff - 1);

            return lookup[n, n + diff] = res;
        }

        int countSeq(int n)
        {            
            for (int k = 0; k < lookup.GetLength(0); k++)
            {
                for (int j = 0; j < lookup.GetLength(1); j++)
                {
                    lookup[k, j] = -1;
                }
            }
            
            return Count(n, 0);
        }
    }
}
