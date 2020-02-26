using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.PatternSearch
{
    public class SumDigitsSquare
    {
        public int SquareDigitSum(string number)
        {
            int sum = 0;

            int num = int.Parse(number);

            int squareNum = num * num;

            while(squareNum > 0)
            {
                sum += (squareNum % 10);
                squareNum /= 10;
            }


            return sum;
        }
    }
}
