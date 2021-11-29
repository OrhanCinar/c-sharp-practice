using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class ProbabilityOfGettingLeastKheadsInNTossesCoins
    {
        double[] fact;

        double Probability(int k, int n)
        {
            double ans = 0;


            for (int i = k; i <= n; i++)
            {
                ans += fact[n] / (fact[i] * fact[n - 1]);
            }

            ans = ans / (1 << n);

            return ans;
        }

        void Precompute()
        {
            fact[0] = fact[1] = 1;

            for (int i = 2; i < 20; ++i)
            {
                fact[i] = fact[i - 1] * i;
            }
        }
    }
}
