using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class LongestCommonIncreasingSubsequence
    {
        int LCIS(int[] arr1, int n, int[] arr2, int m)
        {
            int[] table = new int[m];
            for (int j = 0; j < m; j++)
            {
                table[j] = 0;
            }

            for (int i = 0; i < n; i++)
            {
                int current = 0;

                for (int j = 0; j < m; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        if (current + 1 > table[j])
                        {
                            table[j] = current + 1;
                        }
                    }

                    if (arr1[i] > arr2[j])
                    {
                        if (table[j] > current)
                        {
                            current = table[j];
                        }
                    }
                }
            }

            int result = 0;

            for (int i = 0; i < m; i++)
            {
                if (table[i] > result)
                {
                    result = table[i];
                }
            }

            return result;
        }
    }
}
