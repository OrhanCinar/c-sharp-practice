using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.DataStructures
{
    public class FindMaxMinWinSizeArray
    {
        static int[] arr = { 10, 20, 30, 50, 10, 70, 30 };

        public void PrintMaxOfMin(int n)
        {
            for (int k = 1; k <= n; k++)
            {
                int maxOfMin = int.MinValue;

                for (int i = 0; i <= n - k; i++)
                {
                    int min = arr[i];

                    for (int j = 0; j < k; j++)
                    {
                        if (arr[i + j] < min)
                        {
                            min = arr[i + j];
                        }
                    }

                    if (min > maxOfMin)
                    {
                        maxOfMin = min;
                    }
                }

                Console.Write(maxOfMin + " ");
            }
        }
    }
}
