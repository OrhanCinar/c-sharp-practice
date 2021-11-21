using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class LengthofLongestBalancedSubsequence2
    {
        int MaxLength(String s, int n)
        {
            int invalidOpenBraces = 0;
            int invalidCloseBraces = 0;

            for (int i = 0; i < n; i++)
            {
                if (s[i] == '(')
                {
                    invalidOpenBraces++;
                }
                else
                {
                    if (invalidOpenBraces == 0)
                    {
                        invalidCloseBraces++;
                    }
                    else
                    {
                        invalidOpenBraces--;
                    }
                }
            }

            return n - invalidOpenBraces + invalidCloseBraces;
        }
    }
}
