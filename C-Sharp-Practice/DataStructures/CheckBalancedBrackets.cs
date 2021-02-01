using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.DataStructures
{
    public class BracketStack
    {
        public int top = -1;
        public char[] items = new char[100];

        public void Push(char x)
        {
            if (top == 99)
            {
                Console.WriteLine("Stack Full");
            }
            else
            {
                items[++top] = x;
            }
        }


        public char Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack Underflow");
                return '\0';
            }
            else
            {
                char element = items[top];
                top--;
                return element;
            }
        }

        public bool IsEmpty()
        {
            return top == -1;
        }
    }

    public class CheckBalancedBrackets
    {
        private bool IsMatchinPair(char char1, char char2)
        {
            if (char1 == '(' && char2 == ')')
            {
                return true;
            }

            if (char1 == '[' && char2 == ']')
            {
                return true;
            }

            if (char1 == '{' && char2 == '}')
            {
                return true;
            }

            return false;
        }

        public bool AreBracketBalanced(char[] exp)
        {

            Stack<char> st = new Stack<char>();

            for (int i = 0; i < exp.Length; i++)
            {
                if (exp[i] == '{' || exp[i] == '[' || exp[i] == '(')
                {
                    st.Push(exp[i]);
                }

                if (exp[i] == '}' || exp[i] == ']' || exp[i] == ')')
                {
                    if (st.Count == 0)
                    {
                        return false;
                    }
                    else if (!IsMatchinPair(st.Pop(), exp[i]))
                    {
                        return false;
                    }
                }
            }
            if (st.Count == 0)
            {
                return true; // balanced
            }
            else
            {
                return false;
            }
        }
    }
}
