using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class ValueContinuousFloorFunc
    {
        int max = 10000;
        int[] dp;

        void InitDP()
        {
            dp = new int[max];
            for (int i = 0; i < max; i++)
            {
                dp[i] = -1;
            }
        }

        int Func(int x)
        {
            if(x == 0)
            {
                return 0;
            }

            if (dp[x] == -1)
            {
                dp[x] = x + Func(x / 2);
            }

            return dp[x];
        }
        void PrintFloor(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(Func(arr[i]) + " ");
            }
        }
    }
}
