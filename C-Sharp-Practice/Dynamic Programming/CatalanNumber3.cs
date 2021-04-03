using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    public class CatalanNumber3
    {
        private long BinomialCoeff(int n, int k)
        {
            long res = 1;

            if (k > n - k)
            {
                k = n - k;
            }

            for (int i = 0; i < k; ++i)
            {
                res *= n - i;
                res /= i + 1;
            }

            return res;
        }

        public long Catalan(int n)
        {
            long c = BinomialCoeff(2 * n, n);

            return c / (n + 1);
        }
    }
}
