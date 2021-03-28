using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    public class Fibonacci5
    {
        public int Fib(int n)
        {
            int[,] F = new int[,] { { 1, 1 }, { 1, 0 } };

            if (n == 0)
            {
                return 0;
            }

            Power(F, n - 1);

            return F[0, 0];
        }

        private void Multiply(int[,] F, int[,] M)
        {
            int x = F[0, 0] * M[0, 0] + F[0, 1] * M[1, 0];
            int y = F[0, 0] * M[0, 1] + F[0, 1] * M[1, 1];
            int z = F[1, 0] * M[0, 0] + F[1, 1] * M[1, 0];
            int w = F[1, 0] * M[0, 1] + F[1, 1] * M[1, 1];

            F[0, 0] = x;
            F[0, 1] = y;
            F[1, 0] = z;
            F[1, 1] = w;
        }

        private void Power(int[,] f, int n)
        {
            if (n == 0 || n == 1)
            {
                return;
            }

            int[,] M = new int[,] { { 1, 1 }, { 1, 0 } };

            Power(f, n / 2);

            Multiply(f, f);

            if (n % 2 != 0)
            {
                Multiply(f, M);
            }
        }
    }
}

