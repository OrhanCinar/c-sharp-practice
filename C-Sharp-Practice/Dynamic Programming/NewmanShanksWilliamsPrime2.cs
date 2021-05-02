using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    public class NewmanShanksWilliamsPrime2
    {
        public int NWSP(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }

            int a = 1, b = 1;

            for (int i = 2; i <= n; ++i)
            {
                int c = 2 * b + a;
                a = b;
                b = c;
            }

            return b;
        }
    }
}
