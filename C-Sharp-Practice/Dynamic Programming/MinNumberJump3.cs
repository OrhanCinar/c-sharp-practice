using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class MinNumberJump3
    {
        int MinJumps(int[] arr, int n)
        {

            int[] jumps = new int[n];
            int min;

            jumps[n - 1] = 0;

            for (int i = n - 2; i >= 0; i--)
            {
                if (arr[i] == 0)
                {
                    jumps[i] = int.MaxValue;
                }
                else if (arr[i] >= n - i - 1)
                {
                    jumps[i] = 1;
                }
                else
                {
                    min = int.MaxValue;

                    for (int j = i + 1; j < n && j <= arr[i] + i; j++)
                    {
                        if (min < jumps[j])
                        {
                            min = jumps[j];
                        }
                    }

                    if (min != int.MaxValue)
                    {
                        jumps[i] = min + 1;
                    }
                    else
                    {
                        jumps[i] = min;
                    }
                }
            }

            return jumps[0];
        }
    }
}
