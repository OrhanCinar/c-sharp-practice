using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class MaxDecimalValuePathBinaryMatrix
    {
        int N = 4;

        int MaxDecimalValue(int[,] mat, int i, int j, int p)
        {
            if (i >= N || j >= N)
            {
                return 0;
            }

            int result = Math.Max(MaxDecimalValue(mat, i, j + 1, p + 1), MaxDecimalValue(mat, i + 1, j, p + 1));

            if (mat[i, j] == 1)
            {
                return (int)(Math.Pow(2, p) + result);
            }
            else
            {
                return result; 
            }
        }
    }
}
