using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class CountPossibleDecodings2
    {
        int CountDecodingDP(char[] digits, int n)
        {
            int[] count = new int[n + 1];
            count[0] = 1;
            count[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                count[i] = 0;

                if (digits[i - 1] > '0')
                {
                    count[i] = count[i - 1];
                }

                if (digits[i - 2] == '1' || (digits[i - 2] == '2' && digits[i - 1] < '7'))
                {
                    count[i] += count[i - 2];
                }

            }

            return count[n]; ;
        }
    }
}
