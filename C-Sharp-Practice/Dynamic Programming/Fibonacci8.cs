using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    public class Fibonacci8
    {
        int[] dp = new int[10];

        public int Fib(int n)
        {
            if (n <= 1)
            {
                return n;
            }

            int first, second;

            if (dp[n-1] != -1)
            {
                first = dp[n - 1];
            }
            else
            {
                first = Fib(n - 1);
            }

            if (dp[n - 2] != -1)
            {
                second = dp[n - 2];
            }
            else
            {
                second = Fib(n - 2);
            }

            return dp[n] = first + second;
        }
    }
}
