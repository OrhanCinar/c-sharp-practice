using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class FindMinNumberCoins2
    {
        int MinCoins(int[] coins, int m, int V)
        {
            int[] table = new int[V + 1];

            table[0] = 0;

            for (int i = 1; i <= V; i++)
            {
                table[i] = int.MaxValue;
            }

            for (int i = 1; i <= V; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (coins[j] <= i)
                    {
                        int sub_res = table[i - coins[j]];

                        if (sub_res != int.MaxValue && sub_res + 1 < table[i])
                        {
                            table[i] = sub_res + 1;
                        }
                    }
                }
            }

            return table[V];
        }
    }
}
