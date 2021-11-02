using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class CountDistinctOccurenceSubSeq
    {
        int FindSubsequenceCount(string S, string T)
        {
            int m = T.Length;
            int n = S.Length;

            if (m > n)
            {
                return 0;
            }

            int[,] mat = new int[m + 1, n + 1];

            for (int i = 0; i <= m; i++)
            {
                mat[i, 0] = 0;
            }

            for (int j = 0; j <= n; j++)
            {
                mat[0, j] = 1;
            }

            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (T[i - 1] != S[j - 1])
                    {
                        mat[i, j] = mat[i, j - 1];
                    }
                    else
                    {
                        mat[i, j] = mat[i, j - 1] + mat[i - 1, j - 1];
                    }
                }
            }

            return mat[m, n];
        }
    }
}
