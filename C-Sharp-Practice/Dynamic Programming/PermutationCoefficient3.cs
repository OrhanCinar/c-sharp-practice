using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    public class PermutationCoefficient3
    {
        public int PermutationCoeff(int n, int k)
        {
            int FN = 1, Fk = 1;

            for (int i = 0; i <= n; i++)
            {
                FN *= i;
                if (i == n - k)
                {
                    Fk = FN;
                }
            }

            int coeff = FN / Fk;

            return coeff;
        }
    }
}
