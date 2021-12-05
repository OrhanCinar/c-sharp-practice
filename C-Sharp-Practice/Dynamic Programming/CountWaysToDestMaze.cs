using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class CountWaysToDestMaze
    {
        int R = 4;
        int C = 4;

        int CountPaths(int[,] maze)
        {

            if (maze[0, 0] == -1)
            {
                return 0;
            }


            for (int i = 0; i < R; i++)
            {
                if (maze[i, 0] == 0)
                {
                    maze[i, 0] = 1;
                }
                else
                {
                    break;
                }
            }

            for (int i = 1; i < R; i++)
            {
                for (int j = 1; j < C; j++)
                {
                    if (maze[i, j] == -1)
                    {
                        continue;
                    }

                    if (maze[i - 1, j] > 0)
                    {
                        maze[i, j] = maze[i, j] + maze[i - 1, j];
                    }

                    if (maze[i, j - 1] > 0)
                    {
                        maze[i, j] = maze[i, j] + maze[i, j - 1];
                    }
                }
            }

            return maze[R - 1, C - 1] > 0 ? maze[R - 1, C - 1] : 0;
        }
    }
}
