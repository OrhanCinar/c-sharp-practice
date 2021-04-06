using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    public class BinomialCoefficient2
    {
        public int BinomialCoeff(int n, int k)
        {
            int[,] C = new int[n + 1, k + 1];
            int i, j;

            for (i = 0; i <= n; i++)
            {
                for (j = 0; j <= Math.Min(i, k; j++)
                {
                    if (j == 0 || j == i)
                    {
                        C[i, j] = 1;
                    }
                    else
                    {
                        C[i, j] = C[i - 1, j - 1] + C[i - 1, j];
                    }
                }
            }

            return C[n, k];
        }
    }
}
