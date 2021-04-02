using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    public class CatalanNumber2
    {
        public uint Catalan(uint n)
        {
            uint[] catalan = new uint[n + 2];

            catalan[0] = catalan[1] = 1;

            for (uint i = 2; i <= n; i++)
            {
                catalan[i] = 0;

                for (uint j = 0; j < i; j++)
                {
                    catalan[i] += catalan[j] * catalan[i - j - 1];
                }
            }

            return catalan[n];
        }
    }
}
