using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class LongestSubSeqDiffAdjacents
    {
        int LlongestSubseqWithDiffOne(int[] arr, int n)
        {
            int[] dp = new int[n];

            for (int i = 0; i < n; i++)
            {
                dp[i] = 1;
            }


            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if ((arr[i] == arr[j] + 1) || (arr[i] == arr[j] - 1))
                    {
                        dp[i] = Math.Max(dp[i], dp[j] + 1);
                    }
                }
            }

            int result = 1;

            for (int i = 0; i < n; i++)
            {
                if (result < dp[i])
                {
                    result = dp[i];
                }
            }

            return result;
        }
    }
}
