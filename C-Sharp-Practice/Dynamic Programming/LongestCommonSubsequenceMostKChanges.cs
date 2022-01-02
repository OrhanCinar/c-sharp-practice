using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class LongestCommonSubsequenceMostKChanges
    {
        int MAX = 10;

        int Lcs(int[,,] dp, int[] arr1, int n, int[] arr2, int m, int k)
        {
            if (k < 0)
            {
                return -10000000;
            }

            if (n < 0 || m < 0)
            {
                return 0;
            }

            int ans = dp[n, m, k];

            if (ans != -1)
            {
                return ans;
            }

            try
            {
                ans = Math.Max(Lcs(dp, arr1, n - 1, arr2, m, k), Lcs(dp, arr1, n, arr2, m - 1, k));

                if (arr1[n - 1] == arr2[m - 1])
                {
                    ans = Math.Max(ans, 1 + Lcs(dp, arr1, n - 1, arr2, m - 1, k));
                }

                ans = Math.Max(ans, 1 + Lcs(dp, arr1, n - 1, arr2, m - 1, k - 1));
            }
            catch (Exception)
            {

                throw;
            }

            return ans;
        }
    }
}
