using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    public class GoldMineProblem
    {
        public int GetMaxGold(int[,] gold, int m, int n)
        {
            int[,] goldTable = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    goldTable[i, j] = 0;
                }
            }

            for (int col = n - 1; col >= 0; col--)
            {
                for (int row = 0; row < m; row++)
                {
                    int right = (col == n - 1) ? 0 : goldTable[row, col + 1];

                    int right_up = (row == 0 || col == n - 1) ? 0 : goldTable[row - 1, col + 1];

                    int right_down = (row == m - 1 || col == n - 1) ? 0 : goldTable[row + 1, col + 1];

                    goldTable[row, col] = gold[row, col] + Math.Max(right, Math.Max(right_up, right_down));
                }
            }

            int res = goldTable[0, 0];

            for (int i = 1; i < m; i++)
            {
                res = Math.Max(res, goldTable[i, 0]);
            }

            return res;
        }
    }
}
