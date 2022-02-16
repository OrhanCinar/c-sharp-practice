using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class MinNumSquareSumEqualsToN4
    {
        public class Point
        {
            public int x, y;

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        int NumSquares(int n)
        {
            int[] visited = new int[n + 1];
            Queue q = new Queue();

            int ans = 1000000000;

            q.Enqueue(new Point(n, 0));

            visited[n] = 1;

            while (q.Count != 0)
            {
                Point p = (Point)q.Dequeue();

                if (p.x == 0)
                {
                    ans = Math.Min(ans, p.y);
                }

                for (int i = 1; i * i <= p.x; i++)
                {
                    int path = (p.x - (i * i));

                    if (path >= 0 && (visited[path] == 0) || path == 0)
                    {
                        visited[path] = 1;
                        q.Enqueue(new Point(path, p.y + 1));
                    }
                }
            }

            return ans;
        }
    }
}
