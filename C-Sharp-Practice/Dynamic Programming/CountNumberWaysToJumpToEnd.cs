using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class CountNumberWaysToJumpToEnd
    {
        void CountWaysToJump(int[] arr, int n)
        {
            int[] count_jump = new int[n];

            for (int i = 0; i < n; i++)
            {
                count_jump[i] = 0;
            }

            for (int i = n - 2; i >= 0; i--)
            {
                if (arr[i] >= n - i - 1)
                {
                    count_jump[i]++;
                }

                for (int j = i + 1; j < n - 1 && j < arr[i] + i; j++)
                {
                    if (count_jump[j] != -1)
                    {
                        count_jump[i] += count_jump[j];
                    }
                }

                if (count_jump[i] == 0)
                {
                    count_jump[i] = -1;
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(count_jump[i] + " ");
            }
        }
    }
}
