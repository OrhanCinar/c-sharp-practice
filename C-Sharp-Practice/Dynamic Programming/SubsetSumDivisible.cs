using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    public class SubsetSumDivisible
    {
        public bool ModularSum(int[] arr, int n, int m)
        {
            if (n > m)
            {
                return true;
            }

            bool[] DP = new bool[m];

            for (int i = 0; i < DP.Length; i++)
            {
                DP[i] = false;
            }

            for (int i = 0; i < n; i++)
            {
                if (DP[0])
                {
                    return true;
                }

                bool[] temp = new bool[m];

                for (int l = 0; l < temp.Length; l++)
                {
                    temp[l] = false;
                }

                for (int j = 0; j < m; j++)
                {
                    if (DP[j])
                    {
                        if (!DP[(j + arr[i]) % m])
                        {
                            temp[(j + arr[i]) % m] = true;
                        }
                    }
                }

                for (int j = 0; j < m; j++)
                {
                    if (temp[j])
                    {
                        DP[j] = true;
                    }
                }

                DP[arr[i] % m] = true;
            }

            return DP[0];
        }
    }
}
