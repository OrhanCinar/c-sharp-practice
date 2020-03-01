using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.PatternSearch
{
    public class BoyerMooreGoodSuffix
    {
        public List<int> Search(char[] text, char[] pat)
        {
            var patternList = new List<int>();
            int s = 0, j;
            int m = pat.Length;
            int n = text.Length;

            int[] bpos = new int[m + 1];
            int[] shift = new int[m + 1];

            for (int i = 0; i < m + 1; i++)
            {
                shift[i] = 0;
            }


            PreprocessStrongShift(shift, bpos, pat, m);
            PrepocessCase2(shift, bpos, pat, m);

            while (s <= n - m)
            {
                j = m - 1;

                while (j >= 0 && pat[j] == text[s + j])
                {
                    j--;
                }

                if (j < 0)
                {
                    patternList.Add(s);
                    s += shift[0];
                }
                else
                {
                    s += shift[j + 1];
                }
            }

            return patternList;
        }

        private void PrepocessCase2(int[] shift, int[] bpos, char[] pat, int m)
        {
            int i, j;
            j = bpos[0];

            for (i = 0; i <= m; i++)
            {
                if (shift[i] == 0)
                {
                    shift[i] = j;
                }

                if (i == j)
                {
                    j = bpos[j];
                }
            }

        }

        private void PreprocessStrongShift(int[] shift, int[] bpos, char[] pat, int m)
        {
            int i = m, j = m + 1;
            bpos[i] = j;

            while (i > 0)
            {
                while (j <= m && pat[i - 1] != pat[j - 1])
                {
                    if (shift[j] == 0)
                    {
                        shift[j] = j - i;
                    }

                    j = bpos[j];
                }

                i--;
                j--;
                bpos[i] = j;
            }


        }
    }
}
