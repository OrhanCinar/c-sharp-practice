using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class MoserDeBruijnSequence2
    {
        public int Gen(int n)
        {
            int[] S = new int[n + 1];
            S[0] = 0;

            if (n != 0)
            {
                S[1] = 1;
            }

            for (int i = 2; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    S[i] = 4 * S[i / 2];
                }
                else
                {
                    S[i] = 4 * S[i / 2] + 1;
                }
            }

            return S[n];
        }
    }
}
