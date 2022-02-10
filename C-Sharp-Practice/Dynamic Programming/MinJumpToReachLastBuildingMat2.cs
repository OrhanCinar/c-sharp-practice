using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class MinJumpToReachLastBuildingMat2
    {
        bool IsSafe(int x, int y)
        {
            return (x < 4 && y < 3);
        }

        int MinJump(int[,] height, int x, int y)
        {
            if (x == 4 - 1 && y == 3 - 1)
            {
                return 0;
            }

            int diag = int.MaxValue;

            if (IsSafe(x + 1, y + 1))
            {
                diag = MinJump(height, x + 1, y + 1) + Math.Abs(height[x, y] - height[x + 1, y + 1]);
            }

            int down = int.MaxValue;

            if (IsSafe(x + 1, y))
            {
                down = MinJump(height, x + 1, y) + Math.Abs(height[x, y] - height[x + 1, y]);
            }

            int right = int.MaxValue;

            if (IsSafe(x, y + 1))
            {
                right = MinJump(height, x, y + 1) + Math.Abs(height[x, y]) - height[x, y + 1];
            }

            return Math.Min(down, Math.Min(right, diag));
        }
    }
}
