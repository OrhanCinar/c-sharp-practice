using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class GivenLargeNumberCheckSuSeqDivBy8
    {
        bool IsSubSeqDivisible(string str)
        {
            int i, j, k, l, n = str.Length;

            int[] arr = new int[l];

            for (i = 0; i < n; i++)
            {
                arr[i] = str[i] - '0';
            }

            for (i = 0; i < l; i++)
            {
                for (j = 0; j < l; j++)
                {
                    for (k = 0; k < l; k++)
                    {
                        if (arr[i] % 8 == 0)
                        {
                            return true;
                        }
                        else if ((arr[i] * 10 + arr[j]) % 8 == 0)
                        {
                            return true;
                        }
                        else if ((arr[i] * 100 + arr[j] * 10 + arr[k]) % 8 == 0 && i != j && j != k && i != k)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }
    }
}
