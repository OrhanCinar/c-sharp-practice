using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class CheckValidSeqDivByM
    {
        int MAX = 1000;

        bool IsPossible(int n, int index, int sum, int M, int[] arr, int[,] dp)
        {
            if (index == n)
            {
                if (sum % M == 0)
                {
                    return true;
                }
                return false;
            }
            else if (sum < 0 || sum >= MAX)
            {
                return false;
            }

            if (dp[index, sum] != -1)
            {
                if (dp[index, sum] == 0)
                {
                    return false;
                }
                return true;
            }

            bool placeAdd = IsPossible(n, index + 1, sum + arr[index], M, arr, dp);

            bool placeMinus = IsPossible(n, index + 1, sum - arr[index], M, arr, dp);

            bool res = placeAdd || placeMinus;

            dp[index, sum] = res ? 1 : 0;

            return res;
        }
    }
}
