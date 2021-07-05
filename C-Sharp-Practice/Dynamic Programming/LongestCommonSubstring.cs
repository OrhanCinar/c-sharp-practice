using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class LongestCommonSubstring
    {
        int LCSubStr(string X, string Y, int m, int n)
        {
            int[,] LCStuff = new int[m + 1, n + 1];
            int result = 0;

            for (int i = 0; i <= m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        LCStuff[i, j] = 0;
                    }
                    else if (X[i - 1] == Y[j - 1])
                    {
                        LCStuff[i, j] = LCStuff[i - 1, j - 1] + 1;
                        result = Math.Max(result, LCStuff[i, j]);
                    }
                    else
                    {
                        LCStuff[i, j] = 0;
                    }
                }
            }

            return result;
        }
    }
}
