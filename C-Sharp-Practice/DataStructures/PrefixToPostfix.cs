using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.DataStructures
{
    public class PrefixToPostfix
    {
        public string PreToPost(string exp)
        {
            Stack<string> s = new Stack<string>();

            int length = exp.Length;

            for (int i = length - 1; i >= 0; i--)
            {
                if (IsOperator(exp[i]))
                {
                    string op1 = s.Peek();
                    s.Pop();

                    string op2 = s.Peek();
                    s.Pop();

                    string temp = op1 + op2 + exp[i];

                    s.Push(temp);
                }
                else
                {
                    s.Push(exp[i] + "");
                }
            }

            return s.Peek();
        }

        bool IsOperator(char x)
        {
            switch (x)
            {
                case '+':
                case '-':
                case '/':
                case '*':
                    return true;
                default:
                    return false;
            }
        }
    }
}
