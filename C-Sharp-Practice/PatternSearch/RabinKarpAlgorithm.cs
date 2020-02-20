using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.PatternSearch
{
    public class RabinKarpAlgorithm
    {
        public List<int> Search(string pat, string txt, int q)
        {
            int m = pat.Length;
            int n = txt.Length;
            int i, j = 0;
            int p = 0; // hash value for pattern
            int t = 0; // hash value for txt
            int h = 1;
            int d = 256;
            List<int> patternList = new List<int>();

            for (i = 0; i < m - 1; i++)
            {
                h = (h * d) % q;
            }

            for (i = 0; i < m; i++)
            {
                p = (d * p + pat[i]) % q;
                t = (d * t + txt[i]) % q;
            }


            for (i = 0; i <= n - m; i++)
            {
                if (p == t)
                {
                    for (j = 0; j < m; j++)
                    {
                        if (txt[i + j] != pat[j])
                            break;
                    }

                    if (j == m)
                    {
                        patternList.Add(i);
                    }
                }

                if (i < n - m)
                {
                    t = (d * (t - txt[i] * h) + txt[i + m]) % q;

                    if (t < 0)
                    {
                        t += q;
                    }
                }
            }


            return patternList;
        }
    }
}
