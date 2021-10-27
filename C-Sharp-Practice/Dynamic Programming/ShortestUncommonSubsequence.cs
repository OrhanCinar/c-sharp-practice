using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class ShortestUncommonSubsequence
    {
        int MAX = 1005;
        int shortestSeq(char[] S, char[] T, int m, int n)
        {
            if (m == 0)
            {
                return MAX;
            }

            if (n <= 0)
            {
                return 1;
            }

            int k;

            for (k = 0; k < n; k++)
            {
                if (T[k] == S[0])
                {
                    break;
                }
            }

            if (k == n)
            {
                return 1;
            }

            char[] St1 = new char[S.Length - 1];
            Array.Copy(S, 1, St1, 0, S.Length - 1);

            char[] St2 = new char[S.Length - 1];
            Array.Copy(S, 1, St2, 0, S.Length - 1);

            char[] Tt1 = new char[T.Length - (k + 1)];
            Array.Copy(T, k + 1, Tt1, 0, T.Length - (k + 1));

            return Math.Min(shortestSeq(St1, T, m - 1, n), 1 + shortestSeq(St2, Tt1, m - 1, n - k - 1));

        }
    }
}
