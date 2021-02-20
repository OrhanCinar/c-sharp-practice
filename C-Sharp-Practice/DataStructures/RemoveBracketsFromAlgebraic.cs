using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.DataStructures
{
    public class RemoveBracketsFromAlgebraic
    {
        public string Simplfy(string str)
        {
            int len = str.Length;

            char[] res = new char[len];
            int index = 0, i = 0;

            Stack<int> s = new Stack<int>();
            s.Push(0);

            while (i < len)
            {
                if (str[i] == '+')
                {
                    if (s.Peek() == 1)
                    {
                        res[index++] = '-';
                    }

                    if (s.Peek() == 0)
                    {
                        res[index++] = '+';
                    }
                }
                else if (str[i] == '-')
                {
                    if (s.Peek() == 1)
                    {
                        res[index++] = '+';
                    }
                    else if (s.Peek() == 0)
                    {
                        res[index++] = '-';
                    }
                }
                else if (str[i] == '(' && i > 0)
                {
                    if (str[i - 1] == '-')
                    {
                        int x = s.Peek() == 1 ? 0 : 1;
                        s.Push(x);
                    }
                    else if (str[i - 1] == '+')
                    {
                        s.Push(s.Peek());
                    }
                }
                else if (str[i] == ')')
                {
                    s.Pop();
                }
                else
                {
                    res[index++] = str[i];
                }
            }

            return new string(res);
        }
    }
}
