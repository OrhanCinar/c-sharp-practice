using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class LongestPalindromicSubstring2
    {
        void PrintSubStr(string str, int low, int high)
        {
            Console.WriteLine(str.Substring(low, high - low + 1));
        }

        int LongestPalSubstr(string str)
        {
            int n = str.Length;
            bool[,] table = new bool[n, n];

            int maxLength = 1;

            for (int i = 0; i < n; ++i)
            {
                table[i, i] = true;
            }

            int start = 0;

            for (int i = 0; i < n - 1; ++i)
            {
                if (str[i] == str[i + 1])
                {
                    table[i, i + 1] = true;
                    start = i;
                    maxLength = 2;
                }
            }

            for (int k = 0; k < n; ++k)
            {
                for (int i = 0; i < n - k + 1; ++i)
                {
                    int j = i + k - 1;

                    if (table[i + 1, j - 1] && str[i] == str[j])
                    {
                        table[i, j] = true;

                        if (k > maxLength)
                        {
                            start = i;
                            maxLength = k;
                        }
                    }
                }
            }

            Console.Write("Longest palindrome substring is: ");
            PrintSubStr(str, start, start + maxLength - 1);

            return maxLength;
        }
    }

}
