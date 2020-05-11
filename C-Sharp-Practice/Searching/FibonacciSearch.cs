using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.Searching
{
    public class FibonacciSearch
    {
        public int Search(int[] arr, int x, int n)
        {
            int fibMm2 = 0; //m-2
            int fibMm1 = 1; //m-1

            int fibM = fibMm2 + fibMm1; // m'th

            while (fibM < n)
            {
                fibMm2 = fibMm1;
                fibMm1 = fibM;
                fibM = fibMm2 + fibMm1;
            }

            int offset = -1;

            while (fibM > 1)
            {
                int i = Math.Min(offset + fibMm2, n - 1);

                if (arr[i] < x)
                {
                    fibM = fibMm1;
                    fibMm1 = fibMm2;
                    fibMm2 = fibM - fibMm1;
                    offset = i;
                }
                else if (arr[i] > x)
                {
                    fibM = fibMm2;
                    fibMm1 = fibMm1 - fibMm2;
                    fibMm2 = fibM - fibMm1;
                }
                else
                {
                    return i;
                }
            }
            if (fibMm1 == 1 && arr[offset + 1] == x)
            {
                return offset + 1;
            }


            return 1;
        }
    }
}
