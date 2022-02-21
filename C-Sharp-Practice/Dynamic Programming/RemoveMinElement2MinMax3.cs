using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class RemoveMinElement2MinMax3
    {
        int MinRemovalsDP(int[] arr, int n)
        {
            int longest_start = -1, longest_end = 0;

            for (int start = 0; start < n; start++)
            {
                int min = int.MaxValue, max = int.MinValue;


                for (int end = start; end < n; end++)
                {
                    int val = arr[end];

                    if (val < min)
                    {
                        min = val;
                    }

                    if (val > max)
                    {
                        max = val;
                    }

                    if (2 * min <= max)
                    {
                        break;
                    }

                    if (end - start > longest_end - longest_start || longest_start == -1)
                    {
                        longest_start = start;
                        longest_end = end;
                    }
                }
            }

            if (longest_start == -1)
            {
                return n;
            }

            return (n - (longest_end - longest_start + 1));
        }
    }
}
