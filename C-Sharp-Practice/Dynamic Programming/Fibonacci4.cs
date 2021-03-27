using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    public class Fibonacci4
    {
        public int Fib(int n)
        {
            int[,] F = new int[,] { { 1, 1 }, { 1, 2 } };

            if (n == 0)
            {
                return 0;
            }

            Power(F, n - 1);

            return F[0, 0];
        }

        private void Power(int[,] F, int n)
        {
            int i;
            int[,] M = new int[,] { { 1, 1 }, { 1, 0 } };

            for (i = 2; i <= n; i++)
            {
                Multiply(F, M);
            }
        }

        private void Multiply(int[,] f, int[,] m)
        {
            int x = f[0, 0] * m[0, 0] + f[0, 1] * m[1, 0];
            int y = f[0, 0] * m[0, 1] + f[0, 1] * m[1, 1];
            int z = f[1, 0] * m[0, 0] + f[1, 1] * m[1, 0];
            int w = f[1, 0] * m[0, 1] + f[1, 1] * m[1, 1];

            f[0, 0] = x;
            f[0, 1] = y;
            f[1, 0] = z;
            f[1, 1] = w;
        }
    }
}
