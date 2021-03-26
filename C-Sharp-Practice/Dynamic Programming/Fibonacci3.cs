using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    public class Fibonacci3
    {
        public int Fib(int n)
        {
            int a = 0, b = 1, c = 0;

            if (n == 0)
            {
                return a;
            }

            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b; 
                b = c;
            }

            return b;
        }
    }
}
