using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class MaxProfitBuySellShareTwice
    {
        int MaxProfit(int[] price, int n)
        {
            int[] profit = new int[n];

            for (int i = 0; i < n; i++)
            {
                profit[i] = 0;
            }

            int max_price = profit[n - 1];

            for (int i = n - 2; i >= 0; i--)
            {
                if (profit[i] > max_price)
                {
                    max_price = price[i];
                }

                profit[i] = Math.Max(profit[i + 1], max_price - price[i]);
            }

            int min_price = price[0];

            for (int i = 1; i < n; i++)
            {
                if (price[i] < min_price)
                {
                    min_price = price[i];
                }

                profit[i] = Math.Max(profit[i - 1], profit[i] - min_price);
            }

            int result = profit[n - 1];

            return result;
        }
    }
}
