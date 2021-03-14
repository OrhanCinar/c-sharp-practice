using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    public class OverlappingSubproblems
    {
        int MAX = 100;
        int NIL = -1;
        int[] lookup;

        public OverlappingSubproblems()
        {
            lookup = new int[MAX];

            for (int i = 0; i < MAX; i++)
            {
                lookup[i] = NIL;
            }
        }


        int Fib(int n)
        {
            if (lookup[n] == NIL)
            {
                if (n <= 1)
                {
                    lookup[n] = n;
                }
                else
                {
                    lookup[n] = Fib(n - 1) + Fib(n - 2);
                }
            }

            return lookup[n];
        }
    }
}
