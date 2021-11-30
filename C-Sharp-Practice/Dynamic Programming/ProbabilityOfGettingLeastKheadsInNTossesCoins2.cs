using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class ProbabilityOfGettingLeastKheadsInNTossesCoins2
    {
        int MAX = 100001;
        double[] dp;

        public ProbabilityOfGettingLeastKheadsInNTossesCoins2()
        {
            dp = new double[MAX];
        }

        double Probability(int k, int n)
        {
            double ans = 0.0;

            for (int i = 0; i <= n; ++i)
            {
                double res = dp[n] - dp[i] - dp[n - i] - n;
                ans += Math.Pow(2.0, res);
            }

            return ans;
        }

        void Precompute()
        {
            for (int i = 2; i < MAX; ++i)
            {
                dp[i] = (Math.Log(i) / Math.Log(2)) + dp[i - 1];
            }
        }
    }
}
