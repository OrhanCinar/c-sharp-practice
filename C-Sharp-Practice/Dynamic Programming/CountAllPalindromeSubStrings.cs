using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class CountAllPalindromeSubStrings
    {
        int CountPS(char[] str, int n)
        {
            var arr = new RectangularArrays();
            int[][] dp = arr.ReturnRectangularIntArray(n, n);

            bool[][] P = arr.ReturnRectangularBoolArray(n, n);

            for (int i = 0; i < n; i++)
            {
                P[i][i] = true;
            }

            for (int i = 0; i < n - 1; i++)
            {
                if (str[i] == str[i + 1])
                {
                    P[i][i + 1] = true;
                    dp[i][i + 1] = 1;
                }
            }

            for (int gap = 2; gap < n; gap++)
            {
                for (int i = 0; i < n - gap; i++)
                {
                    int j = gap + i;

                    if (str[i] == str[j] && P[i + 1][j - 1])
                    {
                        P[i][j] = true;
                    }

                    if (P[i][j])
                    {
                        dp[i][j] = dp[i][j - 1] + dp[i + 1][j] + 1 - dp[i + 1][j - 1];

                    }
                    else
                    {
                        dp[i][j] = dp[i][j - 1] + dp[i + 1][j] - dp[i + 1][j - 1];
                    }
                }
            }

            return dp[0][n - 1];
        }
    }

    public class RectangularArrays
    {
        public int[][] ReturnRectangularIntArray(
            int size1, int size2)
        {
            int[][] newArray = new int[size1][];
            for (int array1 = 0; array1 < size1; array1++)
            {
                newArray[array1] = new int[size2];
            }

            return newArray;
        }

        public bool[][] ReturnRectangularBoolArray(
            int size1, int size2)
        {
            bool[][] newArray = new bool[size1][];
            for (int array1 = 0; array1 < size1; array1++)
            {
                newArray[array1] = new bool[size2];
            }

            return newArray;
        }
    }
}
