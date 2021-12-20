using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class CountDigitGroupings
    {
        int CountGroups(int position, int previous_sum, int length, string num)
        {
            if (position == length)
            {
                return 1;
            }

            int res = 0;

            int sum = 0;

            for (int i = position; i < length; i++)
            {
                sum += num[i] - '0';

                if (sum >= previous_sum)
                {
                    res += CountGroups(i + 1, sum, length, num);
                }
            }

            return res;
        }
    }
}
