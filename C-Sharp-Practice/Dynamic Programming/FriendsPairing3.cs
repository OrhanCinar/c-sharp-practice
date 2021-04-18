using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    public class FriendsPairing3
    {
        public int Count(int n)
        {
            int a = 1, b = 2, c = 0;

            if (n <= 2)
            {
                return n;
            }

            for (int i = 3; i <= n; i++)
            {
                c = b + (i - 1) * a;
                a = b;
                b = c;
            }

            return c;
        }
    }
}
