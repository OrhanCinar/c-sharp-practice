using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class MinSumSubMatrix2DArray
    {
        int ROW = 4;
        int COL = 5;
        int start;
        int finish;

        int Kadane(int[] arr, int n)
        {
            int sum = 0, minSum = Int32.MaxValue, i;

            finish = -1;
            int local_start = 0;

            for (i = 0; i < n; ++i)
            {
                sum += arr[i];

                if (sum > 0)
                {
                    sum = 0;
                    local_start = i + 1;
                }
                else if (sum < minSum)
                {
                    minSum = sum;
                    start = local_start;
                    finish = i;
                }
            }

            if (finish != -1)
            {
                return minSum;
            }

            minSum = arr[0];
            start = finish = 0;

            for (i = 1; i < n; i++)
            {
                if (arr[i] < minSum)
                {
                    minSum = arr[i];
                    start = finish = i;
                }
            }

            return minSum;
        }

        void FindMinSumSubmatrix(int[,] M)
        {
            int minSum = Int32.MaxValue;
            int finalLeft = 0, finalRight = 0, finalTop = 0, finalBottom = 0;
            int left, right, i;
            int[] temp = new int[ROW];
            int sum;

            for (left = 0; left < COL; ++left)
            {
                Array.Fill(temp, 0);

                for (right = left; right < COL; ++right)
                {
                    for (i = 0; i < ROW; ++i)
                    {
                        temp[i] += M[i, right];
                    }

                    sum = Kadane(temp, ROW);

                    if (sum < minSum)
                    {
                        minSum = sum;
                        finalLeft = left;
                        finalRight = right;
                        finalTop = start;
                        finalBottom = finish;
                    }
                }

                Console.WriteLine("(Top, Left): (" + finalTop + ", " + finalLeft + ")");
                Console.WriteLine("(Bottom, Right): (" + finalBottom + ", " + finalRight + ")");
                Console.WriteLine("Minimum sum: " + minSum);
            }
        }
    }
}
