using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class MinNumberJump2
    {
        int MinJumps(int[] arr, int n)
        {
            int[] jumps = new int[n];

            if (n == 0 || arr[0] == 0) { return int.MaxValue; }

            jumps[0] = 0;

            for (int i = 0; i < n; i++)
            {
                jumps[i] = int.MaxValue;

                for (int j = 0; j < i; j++)
                {
                    if (i <= j + arr[j] && jumps[j] != int.MaxValue)
                    {
                        jumps[i] = Math.Max(jumps[i], jumps[j] + 1);
                        break;
                    }
                }
            }


            return jumps[n - 1];
        }
    }
}
