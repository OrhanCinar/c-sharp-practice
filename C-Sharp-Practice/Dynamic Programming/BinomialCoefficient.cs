using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    public class BinomialCoefficient
    {
        public int BinomialCoeff(int n, int k)
        {
            if (k > n)
            {
                return 0;
            }

            if (k == 0 || k == n)
            {
                return 1;
            }

            return BinomialCoeff(n - 1, k - 1) + BinomialCoeff(n - 1, k);
        }

    }
}
