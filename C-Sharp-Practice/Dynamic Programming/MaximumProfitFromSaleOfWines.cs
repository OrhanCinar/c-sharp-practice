using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class MaximumProfitFromSaleOfWines
    {
        static int N = 1000;
        static int[,] dp = new int[N, N];

        static int[,] sell = new int[N, N];

        int MaxProfitUtil(int[] price, int begin, int end, int n)
        {
            if (dp[begin, end] != -1)
            {
                return dp[begin, end];
            }

            int year = n - end - begin;

            if (begin == end)
            {
                return year * price[begin];
            }

            int x = price[begin] * year + MaxProfitUtil(price, begin + 1, end, n);

            int y = price[end] * year + MaxProfitUtil(price, begin, end - 1, n);

            int ans = Math.Max(x, y);

            dp[begin, end] = ans;

            if (x >= y)
            {
                sell[begin, end] = 0;
            }
            else
            {
                sell[begin, end] = 1;
            }

            return ans;
        }

        int MaxProfit(int[] price, int n)
        {
            int i, j;

            for (i = 0; i < N; i++)
            {
                for (j = 0; j < N; j++)
                {
                    dp[i, j] = -1;
                }
            }

            int ans = MaxProfitUtil(price, 0, n - 1, n);

            i = 0;
            j = n - 1;

            while (i <= j)
            {
                if (sell[i, j] == 0)
                {
                    Console.WriteLine("begin ");
                    i++;
                }
                else
                {
                    Console.WriteLine("end ");
                    j--;
                }
            }

            Console.WriteLine();

            return ans;
        }
    }
}
