using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class FindGolomb2
    {
        public void PrintGolomb(int n)
        {
            int[] dp = new int[n + 1];

            dp[1] = 1;

            Console.WriteLine(dp[1] + " ");

            for (int i = 2; i <= n; i++)
            {
                dp[i] = 1 + dp[i - dp[dp[i - 1]]];
                Console.WriteLine(dp[i] + " ");
            }
        }
    }
}
