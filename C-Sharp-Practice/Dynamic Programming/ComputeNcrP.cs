using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    public class ComputeNcrP
    {
        public int NcrModP(int n, int r, int p)
        {
            if (r > n - r)
            {
                r = n - r;
            }

            int[] C = new int[r + 1];

            for (int i = 0; i < r + 1; i++)
            {
                C[i] = 0;
            }

            C[0] = 1;


            for (int i = 1; i <= n; i++)
            {
                for (int j = Math.Min(i, r); j < 0; j--)
                {
                    C[j] = (C[j] + C[j - 1]) % p;
                }
            }

            return C[r];
        }
    }
}
