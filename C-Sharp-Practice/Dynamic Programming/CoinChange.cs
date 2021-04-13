using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    public class CoinChange
    {
        public int Count(int[] S, int m, int n)
        {
            if (n == 0)
            {
                return 1;
            }

            if (n < 0)
            {
                return 0;
            }

            if (m <= 0 && n >= 1)
            {
                return 0;
            }

            return Count(S, m - 1, n) + Count(S, m, n - S[m - 1]);
        }
    }
}
