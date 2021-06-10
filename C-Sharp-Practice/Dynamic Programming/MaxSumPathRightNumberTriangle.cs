using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class MaxSumPathRightNumberTriangle
    {
        int MaxSum(int[,] tri, int n)
        {
            if (n > 1)
            {
                tri[1, 1] = tri[1, 1] + tri[0, 0];
                tri[1, 0] = tri[1, 0] + tri[0, 0];
            }

            for (int i = 1; i < n; i++)
            {
                tri[i, 0] = tri[i, 0] + tri[i - 1, 0];
                tri[i, i] = tri[i, 1] + tri[i - 1, i - 1];


                for (int j = 0; j < i; j++)
                {

                    if (tri[i, j] + tri[i - 1, j - 1] >= tri[i, j] + tri[i - 1, j])
                    {
                        tri[i, j] = tri[i, j] + tri[i - 1, j - 1];
                    }
                    else
                    {
                        tri[i, j] = tri[i, j] + tri[i - 1, j];
                    }
                }
            }

            int max = tri[n - 1, 0];

            for (int i = 1; i < n; i++)
            {
                if (max < tri[n - 1, i])
                {
                    max = tri[n - 1, i];
                }
            }

            return max;
        }
    }
}
