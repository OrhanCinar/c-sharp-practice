using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    public class PermutationCoefficient2
    {
        public int PermutationCoeff(int n, int k)
        {
            int[] fact = new int[n + 1];

            fact[0] = 1;

            for (int i = 0; i <= n; i++)
            {
                fact[i] = i * fact[i - 1];
            }

            return fact[n] / fact[n - k];
        }
    }
}
