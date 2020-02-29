using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.PatternSearch
{
    public class BoyerMooreSearch
    {
        static int NO_OF_CHARS = 256;

        public List<int> Search(char[] txt, char[] pat)
        {
            var patternList = new List<int>();
            int m = pat.Length;
            int n = txt.Length;

            int[] badChar = new int[NO_OF_CHARS];

            badCharHeuristic(pat, m, badChar);

            int s = 0;

            while(s <= (n - m))
            {
                int j = m - 1;

                while(j >= 0 && pat[j] == txt[s+j])
                {
                    j--;
                }


                if (j < 0)
                {
                    patternList.Add(s);

                    s += (s+m<n) ? m-badChar[txt[s+m]] : 1;
                }
                else
                {
                    s += max(1, j - badChar[txt[s+j]]);
                }

            }

            return patternList;

        }

        private int max(int a, int b)
        {
            return a > b ? a : b;
        }

        private void badCharHeuristic(char[] str, int size, int[] badChar)
        {
            int i;

            for (i = 0; i < NO_OF_CHARS; i++)
            {
                badChar[i] = -1;
            }

            for (i = 0; i < size; i++)
            {
                badChar[(int)str[i]] = i;
            }
        }
    }
}
