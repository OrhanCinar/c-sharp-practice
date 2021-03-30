using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    public class Fibonacci7
    {
        public int Fib(int n)
        {
            double phi = (1 + Math.Sqrt(5)) / 2;
            return (int)Math.Round(Math.Pow(phi, n) / Math.Sqrt(5));
        }
    }
}
