using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.DataStructures
{
    public class StockSpanProblem
    {
        public void CalculateSpan(int[] price, int n, int[] s)
        {
            s[0] = 1;

            for (int i = 1; i < n; i++)
            {
                s[i] = 1;

                for (int j = i - 1; j >= 0 && price[i] >= price[j]; j--)
                {
                    s[i]++;
                }
            }
        }
    }
}
