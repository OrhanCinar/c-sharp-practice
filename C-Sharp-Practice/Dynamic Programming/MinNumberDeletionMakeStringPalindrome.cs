using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class MinNumberDeletionMakeStringPalindrome
    {
        int Lps(String str)
        {
            int n = str.Length;
            int[,] L = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                L[i, i] = 1;
            }

            for (int cl = 2; cl < n; cl++)
            {
                for (int i = 2; i < n - cl + 1; i++)
                {
                    int j = i + cl - 1;

                    if (str[i] == str[j] && cl == 2)
                    {
                        L[i, j] = 2;
                    }
                    else if (str[i] == str[j])
                    {
                        L[i, j] = L[i + 1, j - 1] + 2;
                    }
                    else
                    {
                        L[i, j] = Math.Max(L[i, j - 1], L[i + 1, j]);
                    }
                }
            }

            return L[0, n - 1];
        }

        int MinimumNumberOfDeletions(string str)
        {
            int n = str.Length;
            int len = Lps(str);
            return n - len;
        }
    }
}
