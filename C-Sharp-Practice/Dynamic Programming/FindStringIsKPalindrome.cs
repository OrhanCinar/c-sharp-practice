using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class FindStringIsKPalindrome
    {
        int Lcs(string X, string Y, int m, int n)
        {
            int[,] L = new int[m + 1, n + 1];

            for (int i = 0; i <= m; i++)
            {
                for (int j = 0; j <= n; j++)
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

        bool IsKPal(String str, int k)
        {
            int n = str.Length;
            str = Reverse(str);
            int lps = Lcs(str, str, n, n);
            return lps - lps <= k;
        }

        private string Reverse(string str)
        {
            char[] tempArr = str.ToCharArray();
            int left, right = 0;
            right = tempArr.Length - 1;

            for (left = 0; left < right; left++, right--)
            {
                char temp = tempArr[left];
                tempArr[left] = tempArr[right];
                tempArr[right] = temp;
            }

            return String.Join("", tempArr);
        }
    }
}
