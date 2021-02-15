using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.DataStructures
{
    public class ReverseNumberWithStack
    {
        Stack<int> st = new Stack<int>();

        public void Push(int number)
        {
            while (number != 0)
            {
                st.Push(number % 10);
                number = number / 10;
            }
        }

        public int ReverseNumber(int number)
        {
            Push(number);
            int reverse = 0;
            int i = 1;


            while (st.Count > 0)
            {
                reverse = reverse + (st.Peek() * i);
                st.Pop();
                i *= 10;
            }

            return reverse;
        }

    }
}
