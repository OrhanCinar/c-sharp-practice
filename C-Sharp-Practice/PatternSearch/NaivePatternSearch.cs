using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.PatternSearch
{
    public class NaivePatternSearch
    {
        public List<int> NaiveSearch(string text, string pat)
        {
            int m = pat.Length;
            int n = text.Length;
            List<int> patternList = new List<int>();

            for (int i = 0; i <= n-m; i++)
            {
                int j;

                for (j = 0; j < m; j++)
                {
                    if (text[i+j] != pat[j])
                    {
                        break;
                    }                   
                }

                if (j == m)
                {
                    patternList.Add(i);
                }

            }

            return patternList;
        }
    }
}
