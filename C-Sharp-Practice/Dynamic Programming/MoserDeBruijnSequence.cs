using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class MoserDeBruijnSequence
    {
        public int Gen(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else if (n % 2 == 0)
            {
                return 4 * Gen(n / 2);
            }
            else if (n % 2 == 1)
            {
                return 4 * Gen(n / 2) + 1;
            }

            return 0;
        }
    }
}
