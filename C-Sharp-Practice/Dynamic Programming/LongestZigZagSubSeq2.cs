using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class LongestZigZagSubSeq2
    {
        int MaxZigZag(int[] seq, int n)
        {
            if (n == 0)
            {
                return 0;
            }

            int lastSign = 0, length = 1;

            for (int i = 1; i < n; ++i)
            {
                int Sign = Signum(seq[i] - seq[i - 1]);

                if (Sign != 0 && Sign != lastSign)
                {
                    lastSign = Sign;
                    length++;
                }
            }

            return length;
        }

        private int Signum(int n)
        {
            if (n != 0)
            {
                return n > 0 ? 1 : -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
