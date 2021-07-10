using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class SumAllSubStringsOfString2
    {
        int SumOfSubStrings(string num)
        {
            int n = num.Length;
            int prev = ToDigit(num[0]);

            int res = prev;
            int current = 0;

            for (int i = 1; i < n; i++)
            {
                int numi = ToDigit(num[i]);

                current = (i + 1) * numi + 10 * prev;

                res += current;

                prev = current;
            }

            return res;
        }

        private int ToDigit(char v)
        {
            return v - '0';
        }
    }
}
