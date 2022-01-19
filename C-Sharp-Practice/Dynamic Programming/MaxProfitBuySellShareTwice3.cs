using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class MaxProfitBuySellShareTwice3
    {
        int Maxtwobuysell(int[] arr, int size)
        {
            int first_buy = int.MinValue;
            int first_sell = 0;

            int second_buy = int.MinValue;
            int second_sell = 0;

            for (int i = 0; i < size; i++)
            {
                first_buy = Math.Max(first_buy, -arr[i]);
                first_sell = Math.Max(first_sell, first_buy + arr[i]);

                second_buy = Math.Max(second_buy, first_sell - arr[i]);
                second_sell = Math.Max(second_sell, second_buy + arr[i]);
            }

            return second_sell;
        }
    }
}
