using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    public class PermutationCoefficient
    {
        public int PermutationCoeff(int n, int k)
        {
            int[,] P = new int[n + 2, k + 2];

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= Math.Min(i, k); j++)
                {
                    if (j == 0)
                    {
                        P[i, j] = 1;
                    }
                    else
                    {
                        P[i, j] = P[i - 1, j] + (j * P[i - 1, j - 1]);
                    }

                    P[i, j + 1] = 0;
                }
            }

            return P[n, k];
        }
    }
}
