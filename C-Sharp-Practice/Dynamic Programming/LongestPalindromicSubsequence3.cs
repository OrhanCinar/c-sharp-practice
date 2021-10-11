using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class LongestPalindromicSubsequence3
    {
        String Lcs(String a, String b)
        {
            int m = a.Length;
            int n = b.Length;
            char[] X = a.ToCharArray();
            char[] Y = b.ToCharArray();

            int[,] L = new int[m + 1, n + 1];
            int i, j;

            for (i = 0; i <= m; i++)
            {
                for (j = 0; j <= n; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        L[i, j] = 0;
                    }
                    else if (X[i - 1] == Y[j - 1])
                    {
                        L[i, j] = L[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        L[i, j] = Math.Max(L[i - 1, j], L[i, j - 1]);
                    }
                }
            }

            int index = L[m, n];
            char[] lcs = new char[index + 1];

            i = m;
            j = n;

            while (i > 0 && j > 0)
            {
                if (X[i - 1] == Y[j - 1])
                {
                    lcs[index - 1] = X[i -1];
                    i--;
                    j--;
                    index--;
                }
                else if (L[i - 1, j] > L[i, j - 1])
                {
                    i--;
                }
                else
                {
                    j--;
                }
            }


            string ans = "";

            for (int x = 0; x < lcs.Length; x++)
            {
                ans += lcs[x];
            }

            return ans;
        }
    }
}
