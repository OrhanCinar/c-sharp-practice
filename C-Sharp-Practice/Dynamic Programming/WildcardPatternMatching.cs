using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class WildcardPatternMatching
    {
        bool Strmatch(string str, string pattern, int n, int m)
        {
            if (m == 0)
            {
                return n == 0;
            }

            bool[,] lookup = new bool[n + 1, m + 1];

            for (int i = 0; i < n + 1; i++)
            {
                for (int j = 0; j < m + 1; j++)
                {
                    lookup[i, j] = false;
                }
            }

            lookup[0, 0] = true;


            for (int j = 1; j <= m; j++)
            {
                if (pattern[j - 1] == '*')
                {
                    lookup[0, j] = lookup[0, j - 1];
                }
            }

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    if (pattern[j - 1] == '*')
                    {
                        lookup[i, j] = lookup[i, j - 1] || lookup[i - 1, j];
                    }
                    else if (pattern[j - 1] == '?' || str[i - 1] == pattern[j - 1])
                    {
                        lookup[i, j] = lookup[i - 1, j - 1];
                    }
                    else
                    {
                        lookup[i, j] = false;
                    }
                }
            }

            return lookup[n, m];
        }
    }
}
