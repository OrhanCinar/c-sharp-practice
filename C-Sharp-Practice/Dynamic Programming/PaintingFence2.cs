using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    public class PaintingFence2
    {
        public long Count(int n, int k)
        {
            long total = k;
            int mod = 1000000007;

            long same = 0, diff = k;

            for (int i = 2; i <= n; i++)
            {
                same = diff;
                diff = total * (k - 1);
                diff = diff % mod;
                total = (same + diff) % mod;
            }

            return total;
        }
    }
}
