using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class CountWaysBuildStreet2
    {
        int Countways(int n)
        {
            int[] A = new int[n + 1];
            A[0] = 1;
            A[1] = 3;
            A[2] = 7;

            for (int i = 2; i <= n; i++)
            {
                A[i] = 2 * A[i - 1] + A[i - 2];
            }

            return A[n];
        }
    }
}
