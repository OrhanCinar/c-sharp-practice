using System;

namespace C_Sharp_Practice.Arrays
{
    public class ArrayRotation
    {
        /// <summary>
        /// Using temp array
        /// </summary>
        /// <param name="input"></param>
        /// <param name="d"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public int[] ArrayRoration1(int[] input, int d, int n)
        {
            int[] tmpArray = new int[d];
            for (int i = 0; i < d; i++)
            {
                tmpArray[i] = input[i];
            }

            for (int i = d; i < n; i++)
            {
                input[i - d] = input[i];
            }

            for (int i = 0; i < d; i++)
            {
                input[n - d + i] = tmpArray[i];
            }

            return input;
        }

        /// <summary>
        /// Rotate one by one
        /// </summary>
        /// <param name="input"></param>
        /// <param name="d"></param>
        /// <param name="n"></param>
        /// <returns></returns>       
        public int[] ArrayRoration2(int[] input, int d, int n)
        {
            for (int i = 0; i < d; i++)
            {
                LeftRotate(input, n);
            }

            return input;
        }

        private int[] LeftRotate(int[] input, int n)
        {
            int i = 0;
            int tmp = input[0];

            for (i = 0; i < n - 1; i++)
            {
                input[i] = input[i + 1];

            }

            input[i] = tmp;

            return input;
        }

        /// <summary>
        /// Juggling Algorithm
        /// </summary>
        /// <param name="input"></param>
        /// <param name="d"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public int[] ArrayRoration3(int[] input, int d, int n)
        {
            int i, j, k, temp;

            for (i = 0; i < gcd(d,n); i++)
            {
                temp = input[i];
                j = i;
                while (true)
                {
                    k = j + d;
                    if (k >= n)
                    {
                        k = k - n;
                    }

                    if (k == i)
                    {
                        break;
                    }

                    input[j] = input[k];
                    j = k;
                }
                input[j] = temp;
            }

            return input;
        }

        private int gcd(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            return gcd(b, a % b);
        }
    }
}
