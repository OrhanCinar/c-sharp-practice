using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice
{
    public class VariousAlgorithm
    {
        public int PowerOfInteger(int x, int y)
        {
            int p = 0;
            if (y == 0)
                return 1;

            int temp = PowerOfInteger(x, y / 2);

            if (y % 2 == 0)
                p = temp * temp;
            else
                p = x * temp * temp;

            return p;
        }
    }
}
