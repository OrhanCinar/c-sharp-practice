using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class MinNumberJump
    {
        int MinJumps(int[] arr, int l, int h)
        {
            if (h == l)
            {
                return 0;
            }

            if (arr[l] == 0)
            {
                return int.MaxValue;
            }

            int min = int.MaxValue;


            for (int i = l + 1; i <= h && i <= l + arr[l]; i++)
            {
                int jumps = MinJumps(arr, i, h);

                if (jumps != int.MaxValue && jumps + 1 < min)
                {
                    min = jumps + 1;
                }
            }

            return min;
        }
    }
}
