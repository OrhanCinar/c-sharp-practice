using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class RencontresNumber
    {
        int BinomialCoeff(int n, int k)
        {
            if (k == 0 || k == n)
            {
                return 1;
            }

            return BinomialCoeff(n - 1, k - 1) + BinomialCoeff(n - 1, k);
        }

        int RencontresNumbers(int n, int m)
        {
            if (n == 0 && m == 0)
            {
                return 1;
            }

            if (n == 1 && m == 0)
            {
                return 0;
            }

            if (m == 0)
            {
                return (n - 1) * (RencontresNumbers(n - 1, 0) + RencontresNumbers(n - 2, 0));
            }

            return BinomialCoeff(n, m) * RencontresNumbers(n - m, 0);
        }
    }
}
