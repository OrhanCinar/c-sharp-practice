using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class GolombSequence
    {
        public int FindGolomb(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            return 1 + FindGolomb(n - FindGolomb(FindGolomb(n - 1)));
        }
    }
}
