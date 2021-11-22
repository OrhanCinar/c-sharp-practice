using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class NonDecreasingSubSeqOfSizeKMinSum
    {
        public int MAX = 100;
        public int inf = 1000000;


        public int[,] dp;

        public NonDecreasingSubSeqOfSizeKMinSum()
        {
            dp = new int[MAX, MAX];
        }

        void initialize()
        {
            for (int i = 0; i < MAX; i++)
            {
                for (int j = 0; j < MAX; j++)
                {
                    dp[i, j] = -1;
                }
            }
        }

        int Solve(int[] arr, int i, int k)
        {
            int ans = 0;

            if (dp[i, k] != -1)
            {
                return dp[i, k];
            }

            if (i < 0)
            {
                return inf;
            }

            if (k == 1)
            {
                ans = inf;

                for (int j = 0; j <= i; j++)
                {
                    ans = Math.Min(ans, arr[i]);
                    return ans;
                }
            }


            ans = inf;

            for (int j = 0; j < i; j++)
            {
                if (arr[i] >= arr[j])
                {
                    ans = Math.Min(ans, Math.Min(Solve(arr, j, k), Solve(arr, j, k - 1) + arr[i]));
                }
                else
                {
                    ans = Math.Min(ans, Solve(arr, j, k));
                }
            }

            dp[i, k] = ans;
            return dp[i, k];
        }
    }
}
