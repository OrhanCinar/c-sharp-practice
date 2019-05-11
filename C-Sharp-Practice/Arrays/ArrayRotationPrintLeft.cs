using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.Arrays
{
    public class ArrayRotationPrintLeft
    {
        public string PrintLeft(int[] arr, int n, int k)
        {
            int mod = k % n;

            string output = "";
            for (int i = 0; i < n; ++i)
            {
                output += arr[(i + mod) % n] + " ";
            }

            return output;
        }
    }
}
