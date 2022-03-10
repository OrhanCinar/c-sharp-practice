using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class FindLongestPathInMatrix
    {
        int n = 3;

        int FindLongestFromACell(int i, int j, int[][] mat, int[][] dp)
        {
            if (i < 0 || i >= n || j < 0 || j >= n)
            {
                return 0;
            }

            if (dp[i][j] != -1)
            {
                return dp[i][j];
            }

            int x = int.MinValue, y = int.MinValue, z = int.MinValue, w = int.MinValue;

            if (j < n - 1 && ((mat[i][j] + 1) == mat[i][j + 1]))
            {
                x = dp[i][j] = 1 + FindLongestFromACell(i, j + 1, mat, dp);
            }

            if (j > 0 && (mat[i][j] + 1 == mat[i][j - 1]))
            {
                y = dp[i][j] = 1 + FindLongestFromACell(i, j + 1, mat, dp);
            }

            if (i > 0 && (mat[i][j] + 1 == mat[i - 1][j]))
            {
                z = dp[i][j] = 1 + FindLongestFromACell(i - 1, j, mat, dp);
            }

            if (i < n - 1 && (mat[i][j] + 1 == mat[i + 1][j]))
            {
                w = dp[i][j] = 1 + FindLongestFromACell(i + 1, j, mat, dp);
            }

            dp[i][j] = Math.Max(x, Math.Max(y, Math.Max(z, Math.Max(w, 1))));

            return dp[i][j];
        }

        public int FinLongestOverAll(int[][] mat)
        {

            int result = 1;

            var r = new RectangularArrays();

            int[][] dp = r.ReturnRectangularIntArray(n, n);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dp[i][j] = -1;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (dp[i][j] == -1)
                    {
                        FindLongestFromACell(i, j, mat, dp);
                    }

                    result = Math.Max(result, dp[i][j]);
                }
            }

            return result;
        }

        public class RectangularArrays
        {
            public int[][] ReturnRectangularIntArray(int size1,
                                                            int size2)
            {
                int[][] newArray = new int[size1][];
                for (int array1 = 0;
                     array1 < size1; array1++)
                {
                    newArray[array1] = new int[size2];
                }

                return newArray;
            }
        }
    }
}
