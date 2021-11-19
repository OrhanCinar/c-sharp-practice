using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class LongestCommonSubsequence5
    {
        int N = 100;

        static int[,] L;

        public LongestCommonSubsequence5()
        {
            L = new int[N, N];
        }

        HashSet<String> FindLCS(String X, String Y, int m, int n)
        {
            HashSet<string> s = new HashSet<string>();

            if (m == 0 || n == 0)
            {
                s.Add("");
                return s;
            }


            if (X[m - 1] == Y[n - 1])
            {
                HashSet<string> tmp = FindLCS(X, Y, m - 1, n - 1);

                foreach (var item in tmp)
                {
                    s.Add(item + X[m - 1]);
                }
            }
            else
            {
                if (L[m - 1, n] >= L[m, n - 1])
                {
                    s = FindLCS(X, Y, m - 1, n);
                }

                if (L[m, n - 1] >= L[m - 1, n])
                {
                    HashSet<string> tmp = FindLCS(X, Y, m, n - 1);

                    foreach (var item in tmp)
                    {
                        s.Add(item);
                    }
                }
            }

            return s;

        }
    }
}
