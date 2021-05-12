using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class FibonacciReverse
    {
        public void ReverseFib(int n)
        {
            int[] a = new int[n];

            a[0] = 0;
            a[1] = 1;

            for (int i = 2; i < n; i++)
            {
                a[i] = a[i - 2] + a[i - 1];
            }

            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write(a[i] + " ");
            }
        }
    }
}
