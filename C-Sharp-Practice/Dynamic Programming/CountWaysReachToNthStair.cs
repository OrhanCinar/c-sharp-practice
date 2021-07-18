using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class CountWaysReachToNthStair
    {
        int FindStep(int n)
        {
            if (n == 1 || n == 0)
            {
                return 1;
            }
            else if (n == 2)
            {
                return 2;
            }
            else
            {
                return FindStep(n - 3) + FindStep(n - 2) + FindStep(n - 1);
            }
        }
    }
}
