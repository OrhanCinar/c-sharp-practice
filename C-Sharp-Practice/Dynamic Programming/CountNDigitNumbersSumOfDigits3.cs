using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class CountNDigitNumbersSumOfDigits3
    {
        void FindCount(int n, int sum)
        {
            int start = (int)Math.Pow(10, n - 1);
            int end = (int)Math.Pow(10, n) - 1;

            int count = 0;
            int i = start;

            while (i < end)
            {
                int curr = 0;
                int temp = i;

                while (temp != 0)
                {
                    curr += temp % 10;
                    temp = temp / 10;
                }

                if (curr == sum)
                {
                    count++;
                    i += 9;
                }
                else
                {
                    i++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
