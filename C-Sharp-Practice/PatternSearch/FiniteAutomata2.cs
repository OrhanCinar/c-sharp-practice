using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.PatternSearch
{
    public class FiniteAutomata2
    {
        static int NO_OF_CHARS = 256;


        public List<int> Search(char[] pat, char[] txt)
        {
            List<int> patternList = new List<int>();
            int m = pat.Length;
            int n = txt.Length;

            int[,] TF = new int[m + 1, NO_OF_CHARS];

            ComputeTransFun(pat, m, TF);

            int i, j = 0;

            for (i = 0; i < n; i++)
            {
                j = TF[j, txt[i]];

                if (j == m)
                {
                    patternList.Add(i-m+1);
                }
            }

            return patternList;
        }

        void ComputeTransFun(char[] pat, int m , int[,] TF)
        {
            int i, lps = 0, x;

            for (x = 0; x < NO_OF_CHARS; x++)
            {
                TF[0, x] = 0;
            }

            TF[0, pat[0]] = 1;


            for (i = 1; i < m; i++)
            {
                for (x = 0; x < NO_OF_CHARS; x++)
                {
                    TF[i, x] = TF[lps, x];
                }

                TF[i, pat[i]] = i + 1;

                if (i < m)
                {
                    lps = TF[lps, pat[i]];
                }
            }
        }
    }
}
