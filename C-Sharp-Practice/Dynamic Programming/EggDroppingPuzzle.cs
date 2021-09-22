using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class EggDroppingPuzzle
    {
        int EggDrop(int n, int k)
        {
            if (k == 1 || k == 0)
            {
                return k;
            }

            if (n == 1)
            {
                return k;
            }

            int min = int.MaxValue;
            int x, res;


            for (x = 0; x <= k; x++)
            {
                res = Math.Max(EggDrop(n - 1, x - 1), EggDrop(n, k - x));

                if (res < min)
                {
                    min = res;
                }
            }

            return min;
        }
    }
}
