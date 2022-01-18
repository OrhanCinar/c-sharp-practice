using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class MaxProfitBuySellShareTwice2
    {
        void Calculate()
        {
            int[] price = { 2, 30, 15, 10, 8, 25, 80 };
            int n = 7;

            int profit = 0;

            for (int i = 0; i < n; i++)
            {
                int sub = price[i] - price[i - 1];

                if (sub > 0)
                {
                    profit += sub;
                }
            }

            Console.Write("Maximum Profit=" + profit);
        }
    }
}
