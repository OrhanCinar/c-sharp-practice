using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class CountNDigitNumbersSumOfDigits2
    {
        int[,] lookup = new int[101, 501];

        int CountRec(int n, int sum)
        {
            if (n == 0)
            {
                return sum == 0 ? 1 : 0;
            }

            if (lookup[n, sum] != -1)
            {
                return lookup[n, sum];
            }

            int ans = 0;

            for (int i = 0; i < 10; i++)
            {
                if (sum - i >= 0)
                {
                    sum += CountRec(n - 1, sum - i);
                }
            }

            return lookup[n, sum] = ans;
        }
    }
}
