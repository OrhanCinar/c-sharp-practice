using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class SumAllSubStringsOfString
    {
        int SumOfSubstrings(String num)
        {
            int n = num.Length;

            int[] sumOfDigit = new int[n];
            sumOfDigit[0] = num[0] - '0';
            int res = sumOfDigit[0];

            for (int i = 1; i < n; i++)
            {
                int numi = num[i] - '0';
                sumOfDigit[i] = (i + 1) * numi + 10 * sumOfDigit[i - 1];
                res += sumOfDigit[i];
            }

            return res;
        }
    }
}
