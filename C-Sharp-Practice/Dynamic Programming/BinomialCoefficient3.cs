using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    public class BinomialCoefficient3
    {
        public int BinomialCoeff(int n, int k)
        {
            int[] C = new int[k + 1];

            C[0] = 1;

            for (int i = 0; i <= n; i++)
            {
                for (int j = Math.Min(i, k); j > 0; j--)
                {
                    C[j] = C[j] + C[j - 1];
                }
            }

            return C[k];
        }
    }
}
