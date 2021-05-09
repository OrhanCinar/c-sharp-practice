using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class NewmanConwaySequence
    {
        public int Sequence(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            else
            {
                return Sequence(Sequence(n - 1)) + Sequence(n - Sequence(n - 1));
            }
        }
    }
}
