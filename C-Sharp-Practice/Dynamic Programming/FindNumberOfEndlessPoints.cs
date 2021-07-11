using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class FindNumberOfEndlessPoints
    {
        int CountEndless(bool[,] input, int n)
        {
            bool[,] row = new bool[n, n];
            bool[,] col = new bool[n, n];

            for (int j = 0; j < n; j++)
            {
                bool isEndless = true;

                for (int i = n - 1; i >= 0; i--)
                {
                    if (input[i, j] == false)
                    {
                        isEndless = false;
                    }

                    col[i, j] = isEndless;
                }
            }

            for (int i = 0; i < n; i++)
            {
                bool isEndless = true;

                for (int j = n - 1; j >= 0; j--)
                {
                    if (input[i, j] == false)
                    {
                        isEndless = false;
                    }

                    row[i, j] = isEndless;
                }
            }

            int ans = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    if (row[i, j] && col[i, j])
                    {
                        ans++;
                    }
                }
            }

            return ans;
        }
    }
}
