using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class NumberOfPalindromixSubSeq
    {
        int MAX = 100;
        int MAX_CHAR = 26;

        void Precompute(string s, int n, int[,] l, int[,] r)
        {
            l[s[0] - 'a', 0] = 1;

            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < MAX_CHAR; j++)
                {
                    l[j, i] += l[j, i - 1];
                }

                l[s[i] - 'a', i]++;
            }

            r[s[n - 1] - 'a', n - 1] = 1;

            for (int i = n - 2; i >= 0; i--)
            {
                for (int j = 0; j < MAX_CHAR; j++)
                {
                    r[j, i] += r[j, i + 1];
                }

                r[s[i] - 'a', i]++;
            }
        }

        int CountPalindromes(int k, int n, int[,] l, int[,] r)
        {
            int ans = 0;

            if (k == 1)
            {
                for (int i = 0; i < MAX_CHAR; i++)
                {
                    ans += l[i, n - 1];
                }
            }

            if (k == 2)
            {
                for (int i = 0; i < MAX_CHAR; i++)
                {
                    ans += ((l[i, n - 1] * (l[i, n - 1] - 1)) / 2);
                }
                return ans;
            }

            for (int i = 1; i < n - 1; i++)
            {
                for (int j = 0; j < MAX_CHAR; j++)
                {
                    ans += l[j, i - 1] * r[j, i + 1];
                }
            }

            return ans;
        }
    }
}
