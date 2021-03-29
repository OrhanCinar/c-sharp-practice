using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    public class Fibonacci6
    {
        int MAX = 1000;
        int[] f;


        public int Fib(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            if (n == 1 || n == 2)
            {
                return (f[n] = 1);
            }

            if (f[n] != 0)
            {
                return f[n];
            }

            int k = (n & 1) == 1 ? (n + 1) / 2 : n / 2;

            f[n] = (n & 1) == 1 ? (Fib(k) * Fib(k) + Fib(k - 1) * Fib(k - 1)) : (2 * Fib(k - 1) + Fib(k)) * Fib(k);

            return f[n];
        }
    }
}
