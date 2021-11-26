using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class FindMinNumberCoins
    {
        int MinCoins(int[] coins, int m, int V)
        {
            if (V == 0)
            {
                return 0;
            }

            int res = int.MaxValue;

            for (int i = 0; i < m; i++)
            {
                if (coins[i] <= V)
                {
                    int sub_res = MinCoins(coins, m, V - coins[i]);


                    if (sub_res != int.MaxValue && sub_res + 1 < res)
                    {
                        res = sub_res + 1;
                    }
                }


            }


            return res;
        }
    }
}
