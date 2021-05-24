using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class LongestCommonSubsequence4
    {
        int[,,] dp = new int[100, 100, 100];
        string X = "AGGT12";
        string Y = "12TXAYB";
        string Z = "12XBA";

        int LCSOf3(int i, int j, int k)
        {
            if (i == -1 || j == -1 || k == -1)
            {
                return 0;
            }

            if (dp[i, j, k] != -1)
            {
                return dp[i, j, k];
            }

            if (X[i] == Y[j] && Y[j] == Z[k])
            {
                return dp[i, j, k] = 1 + LCSOf3(i - 1, j - 1, k - 1);
            }
            else
            {
                return dp[i, j, k] = Math.Max(Math.Max(LCSOf3(i - 1, j, k), LCSOf3(i, j - 1, k)), LCSOf3(i, j, k - 1));
            }
        }
    }
}
