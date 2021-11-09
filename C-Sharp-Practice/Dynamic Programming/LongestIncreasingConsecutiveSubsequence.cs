using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class LongestIncreasingConsecutiveSubsequence
    {
        void LongestSubsequence(int[] a, int n)
        {
            Dictionary<int, int> mp = new Dictionary<int, int>();

            int[] dp = new int[n];

            int maximum = -100000000;

            int index = -1;

            for (int i = 0; i < n; i++)
            {
                if (mp.ContainsKey(a[i] - 1))
                {
                    int lastIndex = mp[a[i] - 1] - 1;

                    dp[i] = 1 + dp[lastIndex];
                }
                else
                {
                    dp[i] = 1;
                }

                dp[a[i]] = i + 1;

                if (maximum < dp[i])
                {
                    maximum = dp[i];
                    index = i;
                }
            }

            for (int curr = a[index] - maximum + 1; curr <= a[index]; curr++)
            {
                Console.Write(curr + " ");
            }
        }
    }
}
