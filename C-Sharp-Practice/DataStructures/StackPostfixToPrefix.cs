using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.DataStructures
{
    public class StackPostfixToPrefix
    {
        public string PostToPrefix(string exp)
        {
            Stack<string> s = new Stack<string>();

            int length = exp.Length;

            for (int i = 0; i < length; i++)
            {
                if (IsOperator(exp[i]))
                {
                    string op1 = (string)s.Peek();
                    s.Pop();

                    string op2 = (string)s.Peek();
                    s.Pop();

                    string temp = exp[i] + op2 + op1;
                    s.Push(temp);
                }
                else
                {
                    s.Push(exp[i] + "");
                }
            }

            return (string)s.Peek();
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
