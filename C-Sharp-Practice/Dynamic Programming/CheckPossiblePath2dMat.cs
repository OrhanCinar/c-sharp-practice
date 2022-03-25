using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class CheckPossiblePath2dMat
    {
        bool IsPath(int[,] arr)
        {
            arr[0, 0] = 1;

            for (int i = 1; i < 5; i++)
            {
                if (arr[i, 0] != -1)
                {
                    arr[i, 0] = arr[i - 1, 0];
                }
            }

            for (int j = 1; j < 5; j++)
            {
                if (arr[0, j] != -1)
                {
                    arr[0, j] = arr[0, j - 1];
                }
            }

            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    if (arr[i, j] != -1)
                    {
                        arr[i, j] = Math.Max(arr[i, j - 1], arr[i - 1, j]);
                    }
                }
            }

            return arr[5 - 1, 5 - 1] == 1;
        }
    }
}
