using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class LongestIncreasingOddEvenSubsequence
    {
        int longOddEvenIncSeq(int[] arr, int n)
        {
            int[] lioes = new int[n];

            int maxLen = 0;

            for (int i = 0; i < n; i++)
            {
                lioes[i] = 1;
            }

            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] > arr[j] && (arr[i] + arr[j]) % 2 != 0 && lioes[i] < lioes[j] + 1)
                    {
                        lioes[i] = lioes[j] + 1;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (maxLen < lioes[i])
                {
                    maxLen = lioes[i];
                }
            }

            return maxLen;
        }
    }
}
