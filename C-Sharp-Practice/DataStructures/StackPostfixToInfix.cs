using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.DataStructures
{
    public class StackPostfixToInfix
    {
        public string PostfixToınfix(string exp)
        {
            Stack<string> s = new Stack<string>();

            for (int i = 0; i < exp.Length; i++)
            {
                if (IsOperand(exp[i]))
                {
                    s.Push(exp[i] + "");
                }
                else
                {
                    string op1 = s.Peek();
                    s.Pop();
                    string op2 = s.Peek();
                    s.Pop();

                    s.Push("(" + op2 + exp[i] + op1 + ")");
                }
            }

            return s.Peek();
        }

        bool IsOperand(char x)
        {
            return (x >= 'a' && x <= 'z') || (x >= 'A' && x <= 'Z');
        }
    }
}
