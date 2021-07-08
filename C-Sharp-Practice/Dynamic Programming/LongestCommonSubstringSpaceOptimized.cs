using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class LongestCommonSubstringSpaceOptimized
    {
        int LCSubStr(string X, string Y)
        {
            int m = X.Length;
            int n = Y.Length;

            int result = 0;

            int[,] len = new int[2, n];

            int currRow = 0;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        len[currRow, j] = 0;
                    }
                    else if (X[i - 1] == Y[j - 1])
                    {
                        len[currRow, j] = len[(1 - currRow), (j - 1)] + 1;
                        result = Math.Max(result, len[currRow, j]);
                    }
                    else
                    {
                        len[currRow, j] = 0;
                    }
                }

                currRow = 1 - currRow;
            }

            return result;
        }
    }
}
