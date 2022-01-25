using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class MaxNumberTrailingZero
    {
        int MAX5 = 100;

        int MaximumZeros(int[] arr, int n, int k)
        {
            int[,] subset = new int[k + 1, MAX5 + 5];

            for (int i = 0; i < subset.GetLength(0); i++)
            {
                for (int j = 0; j < subset.GetLength(1); j++)
                {
                    subset[i, j] = -1;
                }
            }

            subset[0, 0] = 0;

            for (int p = 0; p < n; p++)
            {
                int pw2 = 0, pw5 = 0;

                while (arr[p] % 2 == 0)
                {
                    pw2++;
                    arr[p] /= 2;
                }

                while (arr[p] % 5 == 0)
                {
                    pw5++;
                    arr[p] /= 5;
                }

                for (int i = k - 1; i >= 0; i--)
                {
                    for (int j = 0; j < MAX5; j++)
                    {
                        if (subset[i, j] != -1)
                        {
                            subset[i + 1, j + pw5] = Math.Max(subset[i + 1, j + pw5], subset[i, j] + pw2);
                        }
                    }
                }
            }

            int ans = 0;

            for (int i = 0; i < MAX5; i++)
            {
                ans = Math.Max(ans, Math.Min(i, subset[k, i]));
            }

            return ans;
        }
    }
}
