using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class LongestPalindromicSubstring
    {
        int LongestPalSubstr(String str)
        {
            int n = str.Length;


            int maxLength = 1, start = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    int flag = 1;

                    for (int k = 0; k < (j - 1 + 1) / 2; k++)
                    {
                        if (str[i + k] != str[j - k])
                        {
                            flag = 0;
                        }
                    }

                    if (flag != 0 && (j - i + 1) > maxLength)
                    {
                        start = i;
                        maxLength = j - i + 1;
                    }
                }
            }

            Console.Write("longest palindrome subString is: ");
            printSubStr(str, start, start + maxLength - 1);

            return maxLength;
        }

        void printSubStr(String str, int low, int high)
        {
            for (int i = low; i <= high; ++i)
            {
                Console.Write(str[i]);
            }
        }
    }
}
