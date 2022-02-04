﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class MinInsertionFormPalindrome3
    {
        int Lcs(string X, string Y, int m, int n)
        {
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

            return L[m, n];
        }

        int FindMinInsertionsLCS(string str, int n)
        {
        
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            string revString = new string(charArray);
        
            return (n - Lcs(str, revString, n, n));
        }
    }
}
