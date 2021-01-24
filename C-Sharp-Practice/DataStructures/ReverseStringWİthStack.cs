using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.DataStructures
{
    public class StringStack
    {
        public int size;
        public int top;
        public char[] a;

        public bool IsEmpty()
        {
            return top < 0;
        }

        public StringStack(int n)
        {
            size = n;
            top = -1;
            a = new char[size];
        }

        public bool Push(char x)
        {
            if (top >= size)
            {
                Console.WriteLine("Stack Overflow");
                return false;
            }
            else
            {
                a[++top] = x;
                return true;
            }
        }

        public char Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Overflow");
                return ' ';
            }
            else
            {
                char x = a[top--];
                return x;
            }
        }
    }
    public class ReverseStringWİthStack
    {
        public void ReverseString(StringBuilder s)
        {
            int n = s.Length;
            Stack<char> st = new Stack<char>(n);


            int i;
            for (i = 0; i < n; i++)
            {
                st.Push(s[i]);
            }

            for (i = 0; i < n; i++)
            {
                char ch = st.Pop();
                s[i] = ch;
            }
        }
    }
}
