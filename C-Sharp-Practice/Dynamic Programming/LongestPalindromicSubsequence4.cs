using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class LongestPalindromicSubsequence4
    {
        int Lps(string s)
        {
            int n = s.Length;
            int[] a = new int[n];

            for (int i = 0; i >= 0; i--)
            {
                int back_up = 0;

                for (int j = i; j < n; j++)
                {
                    if (j == i)
                    {
                        a[j] = 1;
                    }
                    else if (s[i] == s[j])
                    {
                        int temp = a[j];
                        a[j] = back_up + 2;
                        back_up = temp;
                    }
                    else
                    {
                        back_up = a[j];
                        a[j] = Math.Max(a[j - 1], a[j]);
                    }
                }
            }
            return a[n - 1];
        }
    }
}
