using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class FindMaxLengthSnakeSeq
    {
        static int M = 4;
        static int N = 4;

        public List<Point> FindPath(int[,] grid, int[,] mat, int i, int j)
        {
            List<Point> path = new List<Point>();

            Point pt = new Point(i, j);
            path.Insert(0, pt);

            while (grid[i, j] != 0)
            {
                if (i > 0 && grid[i, j] - 1 == grid[i - 1, j])
                {
                    pt = new Point(i - 1, j);
                    path.Insert(0, pt);
                    i--;
                }
                else if (j > 0 && grid[i, j] - 1 == grid[i, j - 1])
                {
                    pt = new Point(i, j - 1);
                    path.Insert(0, pt);
                    j--;
                }
            }

            return path;
        }

        public void FindSnakeSequence(int[,] mat)
        {
            int[,] lookup = new int[M, N];

            int max_len = 0;

            int max_row = 0;
            int max_col = 0;

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i != 0 || j != 0)
                    {
                        if (i > 0 && Math.Abs(mat[i - 1, j] - mat[i, j]) == 1)
                        {
                            lookup[i, j] = Math.Max(lookup[i, j], lookup[i - 1, j] + 1);

                            if (max_len < lookup[i, j])
                            {
                                max_len = lookup[i, j];
                                max_row = i;
                                max_col = j;
                            }
                        }

                        if (j > 0 && Math.Abs(mat[i, j - 1] - mat[i, j]) == 1)
                        {
                            lookup[i, j] = Math.Max(lookup[i, j], lookup[i, j - 1] + 1);

                            if (max_len < lookup[i, j])
                            {
                                max_len = lookup[i, j];
                                max_row = i;
                                max_col = j;
                            }
                        }
                    }
                }
            }

            Console.Write("Maximum length of Snake " + "sequence is: " + max_len + "\n");

            List<Point> path = FindPath(lookup, mat, max_row, max_col);

            Console.Write("Snake sequence is:");

            foreach (Point it in path)
            {
                Console.Write("\n" + mat[it.x, it.y] +
                             " (" + it.x + ", " + it.y + ")");
            }
        }
    }

    class Point
    {
        public int x, y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
