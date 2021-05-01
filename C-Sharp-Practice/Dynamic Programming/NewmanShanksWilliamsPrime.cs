using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    public class NewmanShanksWilliamsPrime
    {
        public int NWSP(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }

            return 2 * NWSP(n - 1) + NWSP(n - 2);
        }
    }
}
