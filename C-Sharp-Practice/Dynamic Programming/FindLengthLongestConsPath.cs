using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class FindLengthLongestConsPath
    {
        int[] x = { 0, 1, 1, -1, 1, 0, -1, -1 };
        int[] y = { 1, 0, 1, 1, -1, -1, 0, -1 };
        int R = 3;
        int C = 3;

        int[,] dp;
        public FindLengthLongestConsPath()
        {
            dp = new int[R, C];
        }

        bool Isvalid(int i, int j)
        {
            if (i < 0 || j < 0 || i >= R || j >= C)
            {
                return false;
            }

            return true;
        }

        bool Isadjacent(char prev, char curr)
        {
            return ((curr - prev) == 1);
        }

        int GetLenUtil(char[,] mat, int i, int j, char prev)
        {
            if (!Isvalid(i, j) || !Isadjacent(prev, mat[i, j]))
            {
                return 0;
            }

            if (dp[i, j] != -1)
            {
                return dp[i, j];
            }

            int ans = 0;

            for (int k = 0; k < 8; k++)
            {
                ans = Math.Max(ans, 1 + GetLenUtil(mat, i + x[k], j + y[k], mat[i, j]));
            }

            return dp[i, j] = ans;
        }

        int GetLen(char[,] mat, char s)
        {
            for (int i = 0; i < R; i++)
            {
                for (int j = 0; j < C; ++j)
                {
                    dp[i, j] = -1;
                }
            }

            int ans = 0;


            for (int i = 0; i < R; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    if (mat[i, j] == s)
                    {
                        for (int k = 0; k < 8; k++)
                        {
                            ans = Math.Max(ans, 1 + GetLenUtil(mat, i + x[k], y[k], s));
                        }
                    }
                }
            }

            return ans;
        }
    }
}
