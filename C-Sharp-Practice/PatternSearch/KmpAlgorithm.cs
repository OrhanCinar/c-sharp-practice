using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.PatternSearch
{
    public class KmpAlgorithm
    {
        public List<int> KmpAlgorithmSearch(string text, string pat)
        {
            int m = pat.Length;
            int n = text.Length;
            List<int> patternList = new List<int>();

            int[] lps = new int[m];
            int j = 0;

            computeLPSArray(text, m, lps);
            int i = 0;
            while (i < n)
            {

                if (pat[j] == text[i])
                {
                    j++;
                    i++;
                }

                if (j == m)
                {
                    patternList.Add(i - j);
                    j = lps[j - 1];
                }
                else if (i < n && pat[j] != text[i])
                {
                    if (j != 0)
                    {
                        j = lps[j - 1];
                    }
                    else
                    {
                        i = i + 1;
                    }
                }
            }

            return patternList;
        }

        private void computeLPSArray(string text, int m, int[] lps)
        {
            int len = 0;
            int i = 1;
            lps[0] = 0;

            while (i < m)
            {
                if (text[i] == text[len])
                {
                    len++;
                    lps[i] = len;
                    i++;
                }
                else
                {
                    if (len != 0)
                    {
                        len = lps[len - 1];
                    }
                    else
                    {
                        lps[i] = len;
                        i++;
                    }
                }
            }

        }
    }
}
