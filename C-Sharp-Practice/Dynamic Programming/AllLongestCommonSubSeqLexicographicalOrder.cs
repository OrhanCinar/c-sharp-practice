using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class AllLongestCommonSubSeqLexicographicalOrder
    {
        int MAX = 100;

        int lcslen = 0;

        int[,] dp;


        public AllLongestCommonSubSeqLexicographicalOrder()
        {
            dp = new int[MAX, MAX];
        }

        int Lcs(string str1, string str2, int len1, int len2, int i, int j)
        {
            int ret = dp[i, j];

            if (i == len1 || j == len2)
            {
                return ret = 0;
            }

            if (ret != -1)
            {
                return ret;
            }

            ret = 0;

            if (str1[i] == str2[j])
            {
                ret = 1 + Lcs(str1, str2, len1, len2, i + 1, j + 1);
            }
            else
            {
                ret = Math.Max(Lcs(str1, str2, len1, len2, i + 1, j), Lcs(str1, str2, len1, len2, i, j + 1));
            }

            return ret;
        }

        void PrintAll(string str1, string str2, int len1, int len2, char[] data, int indx1, int indx2, int currlcs)
        {
            if (currlcs == lcslen)
            {
                data[currlcs] = '\0';

                Console.WriteLine(new string(data));
                return;
            }

            if (indx1 == len1 || indx2 == len2)
            {
                return;
            }

            for (char ch = 'a'; ch <= 'z'; ch++)
            {
                bool done = false;

                for (int i = indx1; i < len1; i++)
                {
                    if (ch == str1[i])
                    {
                        for (int j = indx2; j < len2; j++)
                        {
                            if (ch == str2[j] && Lcs(str1, str2, len1, len2, i, j) == lcslen - currlcs)
                            {
                                data[currlcs] = ch;
                                PrintAll(str1, str2, len1, len2, data, i + 1, j + 1, currlcs + 1);
                                done = true;
                                break;
                            }
                        }
                    }

                    if (done)
                    {
                        break;
                    }
                }
            }
        }

        void PrinlAllLCSSorted(string str1, string str2)
        {
            int len1 = str1.Length, len2 = str2.Length;

            for (int i = 0; i < MAX; i++)
            {
                for (int j = 0; j < MAX; j++)
                {
                    dp[i, j] = -1;
                }
            }

            lcslen = Lcs(str1, str2, len1, len2, 0, 0);

            char[] data = new char[MAX];

            PrintAll(str1, str2, len1, len2, data, 0, 0, 0);
        }
    }
}
