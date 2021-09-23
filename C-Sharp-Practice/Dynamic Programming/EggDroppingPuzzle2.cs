using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class EggDroppingPuzzle2
    {
        int EggDrop(int n, int k)
        {
            int[,] eggFloor = new int[n + 1, k + 1];
            int res;
            int i, j, x;

            for (i = 0; i <= n; i++)
            {
                eggFloor[i, 1] = 1;
                eggFloor[i, 0] = 0;
            }

            for (j = 1; j < k; j++)
            {
                eggFloor[i, j] = j;
            }

            for (i = 2; i <= n; i++)
            {
                for (j = 2; j <= k; j++)
                {
                    eggFloor[i, j] = int.MaxValue;

                    for (x = 1; x <= j; x++)
                    {
                        res = 1 + Math.Max(eggFloor[i - 1, x - 1], eggFloor[i, j - x]);

                        if (res < eggFloor[i, j])
                        {
                            eggFloor[i, j] = res;
                        }
                    }
                }
            }


            return eggFloor[n, k];
        }
    }
}
