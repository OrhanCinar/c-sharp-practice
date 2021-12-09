using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class CountPossibleDecodings
    {
        int CountDecoding(char[] digits, int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }

            int count = 0;

            if (digits[n - 1] > '0')
            {
                count = CountDecoding(digits, n - 1);
            }

            if (digits[n - 2] == '1' || digits[n - 2] == '2' && digits[n - 1] < '7')
            {
                count += CountDecoding(digits, n - 2);
            }

            return count;
        }
    }
}
