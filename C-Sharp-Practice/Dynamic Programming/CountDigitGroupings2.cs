using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class CountDigitGroupings2
    {
        int MAX = 40;
        int[,] dp;

        public CountDigitGroupings2()
        {
            dp = new int[MAX, 9 * MAX + 1];
        }

        int CountGroups(int position, int previous_sum, int length, char[] num)
        {
            if (position == length)
            {
                return 1;
            }

            if (dp[position, previous_sum] != -1)
            {
                return dp[position, previous_sum];
            }

            dp[position, previous_sum] = 0;

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

            dp[position, previous_sum] = res;

            return res;
        }
    }
}
