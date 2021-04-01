using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    public class CatalanNumber
    {
        public int Catalan(int n)
        {
            int res = 0;


            if (n <= 1)
            {
                return 1;
            }

            for (int i = 0; i < n; i++)
            {
                res += Catalan(i) * Catalan(n - i - 1);
            }


            return res;
        }
    }
}
