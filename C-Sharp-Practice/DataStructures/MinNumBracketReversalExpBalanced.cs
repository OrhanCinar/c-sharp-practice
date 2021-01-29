using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.DataStructures
{
    public class MinNumBracketReversalExpBalanced
    {
        public int CountMinReversal(string exp)
        {
            int len = exp.Length;

            if (len % 2 != 0)
            {
                return -1;
            }

            Stack<char> s = new Stack<char>();

            for (int i = 0; i < len; i++)
            {
                char c = exp[i];

                if (c == '}' && s.Count > 0)
                {
                    if (s.Peek() == '{')
                    {
                        s.Pop();
                    }
                    else
                    {
                        s.Push(c);
                    }
                }
                else
                {
                    s.Push(c);
                }
            }

            int red_len = s.Count;

            int n = 0;

            while (s.Count > 0 && s.Peek() == '{')
            {
                s.Pop();
                n++;
            }

            return red_len / 2 + n % 2;
        }
    }
}
