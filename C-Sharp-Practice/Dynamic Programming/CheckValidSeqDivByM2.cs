using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class CheckValidSeqDivByM2
    {
        int MAX = 100;
        int IsPossible(int n, int index, int modulo, int M, int[] arr, int[,] dp)
        {
            modulo = ((modulo % M) + M) % M;

            if (index == n)
            {
                if (modulo == 0)
                {
                    return 1;
                }
                return 0;
            }

            if (dp[index, modulo] != -1)
            {
                return dp[index, modulo];
            }

            if (dp[index, modulo] != -1)
            {
                return dp[index, modulo];
            }

            int placeAdd = IsPossible(n, index + 1, modulo + arr[index], M, arr, dp);

            int placeMinus = IsPossible(n, index + 1, modulo - arr[index], M, arr, dp);

            int res = placeAdd;

            dp[index, modulo] = res;

            return res;
        }
    }
}
