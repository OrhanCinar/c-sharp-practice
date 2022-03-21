using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class WildcardPatternMatching2
    {
        bool Strmatch(char[] txt, char[] pat, int n, int m)
        {
            if (m == 0)
            {
                return n == 0;
            }

            int i = 0, j = 0, index_txt = -1, index_pat = -1;

            while (i < n)
            {
                if (j < m && txt[i] == pat[j])
                {
                    i++;
                    j++;
                }
                else if (j < m && pat[j] == '?')
                {
                    i++;
                    j++;
                }
                else if (j < m && pat[j] == '*')
                {
                    index_txt = i;
                    index_pat = j;
                    j++;
                }
                else if (index_pat != -1)
                {
                    j = index_pat + 1;
                    i = index_txt + 1;
                    index_txt++;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
