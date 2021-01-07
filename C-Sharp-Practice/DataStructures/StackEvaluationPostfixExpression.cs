using System;
using System.Collections.Generic;

namespace C_Sharp_Practice.DataStructures
{
    public class StackEvaluationPostfixExpression
    {
        private Stack<string> i = new Stack<string>();

        public string Expresion(string v)
        {
            int a, b, ans;

            for (int j = 0; j < v.Length; j++)
            {
                var c = v.Substring(j, 1);

                if (c.Equals("*"))
                {
                    var sa = i.Pop();
                    var sb = i.Pop();
                    a = Convert.ToInt32(sb);
                    b = Convert.ToInt32(sa);

                    ans = a * b;
                    i.Push(ans.ToString());
                }
                else if (c.Equals("/"))
                {
                    var sa = i.Pop();
                    var sb = i.Pop();
                    a = Convert.ToInt32(sb);
                    b = Convert.ToInt32(sa);

                    ans = a / b;
                    i.Push(ans.ToString());
                }
                else if (c.Equals("+"))
                {
                    var sa = i.Pop();
                    var sb = i.Pop();
                    a = Convert.ToInt32(sb);
                    b = Convert.ToInt32(sa);

                    ans = a + b;
                    i.Push(ans.ToString());
                }
                else if (c.Equals("-"))
                {
                    var sa = i.Pop();
                    var sb = i.Pop();
                    a = Convert.ToInt32(sb);
                    b = Convert.ToInt32(sa);

                    ans = a - b;
                    i.Push(ans.ToString());
                }
                else
                {
                    i.Push(v.Substring(j, 1));
                }
            }

            return i.Pop();
        }
    }
}