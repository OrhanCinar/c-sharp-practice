using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class MinNumSquareSumEqualsToN3
    {
        int MinCount(int n)
        {
            int[] minSquareRequired = new int[n + 1];
            minSquareRequired[0] = 0;
            minSquareRequired[1] = 1;


            for (int i = 2; i <= n; i++)
            {
                minSquareRequired[i] = Int32.MaxValue;

                for (int j = 1; i - (j * j) >= 0; ++j)
                {
                    minSquareRequired[i] = Math.Min(minSquareRequired[i], minSquareRequired[i - (j * j)]);
                }

                minSquareRequired[i] += 1;
            }

            int result = minSquareRequired[n];
            return result;
        }
    }
}
