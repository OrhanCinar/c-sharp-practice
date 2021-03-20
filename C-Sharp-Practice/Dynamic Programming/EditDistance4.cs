using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    public class EditDistance4
    {
        public int MinDist(string s1, string s2, int n, int m, List<List<int>> dp)
        {

            if (n == 0)
            {
                return m;
            }


            if (m == 0)
            {
                return n;
            }

            if (dp[n][m] != -1)
            {
                return dp[n][m];
            }

            if (s1[n - 1] == s2[m - 1])
            {
                if (dp[n - 1][m - 1] == -1)
                {
                    return dp[n][m] = MinDist(s1, s2, n - 1, m - 1, dp);
                }
                else
                {
                    return dp[n][m] = dp[n - 1][m - 1];
                }
            }
            else
            {
                int m1, m2, m3;

                if (dp[n - 1][m] != -1)
                {
                    m1 = dp[n - 1][m];
                }
                else
                {
                    m1 = MinDist(s1, s2, n - 1, m, dp);
                }

                if (dp[n][m - 1] != -1)
                {
                    m2 = dp[n][m - 1];
                }
                else
                {
                    m2 = MinDist(s1, s2, n, m - 1, dp);
                }

                if (dp[n - 1][m - 1] != -1)
                {
                    m3 = dp[n - 1][m - 1];
                }
                else
                {
                    m3 = MinDist(s1, s2, n - 1, m - 1, dp);
                }

                return dp[n][m] = 1 + Math.Min(m1, Math.Min(m2, m3));
            }
        }
    }
}
