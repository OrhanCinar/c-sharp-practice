using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    public class BinomialCoefficient4
    {

        public int BinomialCoeffUtil(int n, int k, List<int>[] dp)
        {
            if (dp[n][k] != -1)
            {
                return dp[n][k];
            }

            if (k == 0)
            {
                dp[n][k] = 1;
                return dp[n][k];
            }

            if (k == n)
            {
                dp[n][k] = 1;
                return dp[n][k];
            }


            dp[n][k] = BinomialCoeffUtil(n - 1, k - 1, dp) + BinomialCoeffUtil(n - 1, k, dp);

            return dp[n][k];
        }

        public int binomialCoeff(int n, int k)
        {
            List<int>[] dp = new List<int>[n + 1];

            for (int i = 0; i < n + 1; i++)
            {
                dp[i] = new List<int>();

                for (int j = 0; j <= k; j++)
                {
                    dp[i].Add(-1);
                }
            }

            return BinomialCoeffUtil(n, k, dp);
        }
    }
}
