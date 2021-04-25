using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    public class CuttingARod
    {
        public int CutRod(int[] price, int n)
        {
            if (n <= 0)
            {
                return 0;
            }

            int max_val = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                max_val = Math.Max(max_val, price[i] + CutRod(price, n - i - 1));
            }

            return max_val;
        }
    }
}
