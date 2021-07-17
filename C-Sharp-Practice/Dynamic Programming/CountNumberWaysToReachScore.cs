using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class CountNumberWaysToReachScore
    {
        int Count(int n)
        {

            int[] table = new int[n + 1];

            for (int j = 0; j < n + 1; j++)
            {
                table[j] = 0;
            }

            table[0] = 1;


            for (int i = 2; i <= n; i++)
            {
                table[i] += table[i - 3];
            }

            for (int i = 5; i <= n; i++)
            {
                table[i] += table[i - 5];
            }

            for (int i = 10; i <= n; i++)
            {
                table[i] += table[i - 10];
            }


            return table[n];
        }
    }
}
