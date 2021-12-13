using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class CountNDigitNumbersSumOfDigits
    {
        int CountRec(int n, int sum)
        {
            if (n == 0)
            {
                return sum == 0 ? 1 : 0;
            }

            if (sum == 0)
            {
                return 1;
            }

            int ans = 0;


            for (int i = 0; i < 9; i++)
            {
                if (sum - i >= 0)
                {
                    ans += CountRec(n - 1, sum - 1);
                }
            }

            return ans;
        }

        int FinalCount(int n, int sum)
        {
            int ans = 0;

            for (int i = 1; i < 9; i++)
            {
                if (sum - i >= 0)
                {
                    ans += CountRec(n - 1, sum - i);
                }
            }

            return ans;
        }
    }
}
