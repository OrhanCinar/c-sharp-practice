using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class MaxDiffOfZerosAndOnesBinStr
    {
        int FindLength(string str, int n)
        {
            int current_sum = 0;
            int max_sum = 0;

            for (int i = 0; i < n; i++)
            {
                current_sum += str[i] == '0' ? 1 : -1;

                if (current_sum < 0)
                {
                    current_sum = 0;
                }

                max_sum = Math.Max(current_sum, max_sum);
            }

            return max_sum == 0 ? -1 : max_sum;
        }
    }
}
