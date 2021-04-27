using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    public class CuttingARod3
    {
        public int CutRod(int[] price, int n)
        {
            int[] val = new int[n + 1];

            val[0] = 0;

            for (int i = 0; i < n; i++)
            {
                int max_val = int.MinValue;

                for (int j = 0; j < i; j++)
                {
                    max_val = Math.Max(max_val, price[j] + val[i - j - 1]);
                }

                val[i] = max_val;
            }

            return val[n];
        }
    }
}
