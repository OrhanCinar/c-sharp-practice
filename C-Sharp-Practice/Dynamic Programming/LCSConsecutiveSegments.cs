using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class LCSConsecutiveSegments
    {
        int LongestSubsequenceCommonSegment(int k, string s1, string s2)
        {
            int n = s1.Length;
            int m = s2.Length;

            int[,] lcs = new int[n + 1, m + 1];
            int[,] cnt = new int[n + 1, m + 1];


            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    lcs[i, j] = Math.Max(lcs[i - 1, j], lcs[i, j - 1]);

                    if (s1[i - 1] == s2[j - 1])
                    {
                        cnt[i, j] = cnt[i - 1, j - 1] + 1;
                    }

                    if (cnt[i, j] >= k)
                    {
                        for (int a = k; a <= cnt[i, j]; a++)
                        {
                            lcs[i, j] = Math.Max(lcs[i, j], lcs[i - a, j - a] + a);
                        }
                    }
                }
            }

            return lcs[n, m];
        }
    }
}
