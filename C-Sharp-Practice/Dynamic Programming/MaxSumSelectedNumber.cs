using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class MaxSumSelectedNumber
    {
        int GetMaximumSum(int[] arr)
        {
            int n = arr.Length;

            int max = arr.Max();

            int[] freq = new int[max + 1];

            for (int j = 0; j < n; j++)
            {
                freq[arr[j]]++;
            }

            int ans = 0, i = max;

            while (i > 0)
            {
                if (freq[i] > 0)
                {
                    ans += 1;

                    freq[i - 1]--;
                    freq[i]--;
                }
                else
                {
                    i--;
                }
            }

            return ans;
        }
    }
}
