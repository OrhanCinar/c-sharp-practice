using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class ProbabilityOfReachingAPointW_2_3Steps
    {
        float Find_prob(int N, float P)
        {
            double[] dp = new double[N + 1];
            dp[0] = 1;
            dp[1] = 0;
            dp[2] = P;
            dp[3] = 1 - P;



            for (int i = 4; i <= N; ++i)
            {
                dp[i] = P * dp[i - 2] + (1 - P) * dp[i - 3];
            }

            return (float)dp[N];
        }
    }
}
