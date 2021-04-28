using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    public class TilingWithDominoes
    {
        public int Count(int n)
        {
            int[] A = new int[n + 1];
            int[] B = new int[n + 1];

            A[0] = 1;
            A[1] = 1;

            B[0] = 0;
            B[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                A[i] = A[i - 2] + 2 * B[i - 1];
                B[i] = A[i - 1] + B[i - 2];
            }

            return A[n];
        }
    }
}
