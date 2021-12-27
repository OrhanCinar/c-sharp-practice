using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class CountTotalNumberNDigits
    {
        int[,,,] lookup = new int[50, 1000, 1000, 2];

        int CountRec(int digits, int esum, int osum, int isOdd, int n)
        {
            if (digits == n)
            {
                return (esum - osum == 1) ? 1 : 0;
            }

            if (lookup[digits, esum, osum, isOdd] != -1)
            {
                return lookup[digits, esum, osum, isOdd];
            }

            int ans = 0;

            if (isOdd == 1)
            {
                for (int i = 0; i <= 9; i++)
                {
                    ans += CountRec(digits + 1, esum, osum + 1, 0, n);
                }
            }
            else
            {
                for (int i = 0; i <= 9; i++)
                {
                    ans += CountRec(digits + 1, esum + i, osum, 1, n);
                }
            }

            return lookup[digits, esum, osum, isOdd];
        }

        int FinalCount(int n)
        {
            int digits = 0;

            for (int i = 0; i < 50; i++)
            {
                for (int j = 0; j < 1000; j++)
                {
                    for (int k = 0; k < 1000; k++)
                    {
                        for (int l = 0; l < 2; l++)
                        {
                            lookup[i, j, k, l] = -1;
                        }
                    }
                }
            }

            int ans = 0;

            int esum = 0, osum = 0;


            for (int i = 0; i <= 9; i++)
            {
                ans += CountRec(digits + 1, esum + i, osum, 1, n);
            }

            return ans;
        }
    }
}
