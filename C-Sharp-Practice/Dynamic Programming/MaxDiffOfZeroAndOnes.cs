using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class MaxDiffOfZeroAndOnes
    {
        int MAX = 100;

        bool Allones(string s, int n)
        {
            int co = 0;

            for (int i = 0; i < s.Length; i++)
            {
                co += s[i] == '1' ? 1 : 0;
            }

            return co == n;
        }

        int Findlength(int[] arr, string s, int n, int ind, int st, int[,] dp)
        {
            if (ind >= n)
            {
                return 0;
            }

            if (dp[ind, st] != -1)
            {
                return dp[ind, st];
            }

            if (st == 0)
            {
                return dp[ind, st] = Math.Max(arr[ind] + Findlength(arr, s, n, ind + 1, 1, dp), Findlength(arr, s, n, ind + 1, 0, dp));
            }
            else
            {
                return dp[ind, st] = Math.Max(arr[ind] + Findlength(arr, s, n, ind + 1, 1, dp), 0);
            }
        }

        int MaxLen(string s, int n)
        {
            if (Allones(s, n))
            {
                return -1;
            }

            int[] arr = new int[MAX];

            for (int i = 0; i < n; i++)
            {
                arr[i] = s[i] == '0' ? 1 : -1;
            }

            int[,] dp = new int[MAX, 3];

            for (int i = 0; i < MAX; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    dp[i, j] = -1;
                }
            }

            return Findlength(arr, s, n, 0, 0, dp);
        }
    }
}
