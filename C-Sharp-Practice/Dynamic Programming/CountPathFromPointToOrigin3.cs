using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class CountPathFromPointToOrigin3
    {
        int BinomialCoeff(int n, int k)
        {
            int[] C = new int[k + 1];
            C[0] = 1;

            for (int i = 1; i <= n; i++)
            {
                for (int j = Math.Min(i,k); j > 0; j--)
                {
                    C[j] = C[j] + C[j - 1];
                }
            }

            return C[k];
        }
    }
}
