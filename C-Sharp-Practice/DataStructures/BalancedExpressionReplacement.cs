using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.DataStructures
{
    public class BalancedExpressionReplacement
    {
        int IsMatching(char a, char b)
        {
            if ((a == '{' && b == '}') ||
            (a == '[' && b == ']') ||
            (a == '(' && b == ')') || a == 'X')
                return 1;
            return 0;
        }

        public int IsBalanced(string s, Stack<char> st, int ind)
        {
            if (ind == s.Length)
            {
                return 1;
            }
            else
            {
                return 0;
            }

            char topElement;
            int res;

            if (s[ind] == '{' || s[ind] == '(' || s[ind] == '[')
            {
                st.Push(s[ind]);
                return IsBalanced(s, st, ind + 1);
            }
            else if (s[ind] == '}' || s[ind] == ')' || s[ind] == ']')
            {
                if (st.Count == 0)
                {
                    return 0;
                }

                topElement = st.Peek();
                st.Pop();

                if (IsMatching(topElement, s[ind]) == 0)
                {
                    return 0;
                }
                return IsBalanced(s, st, ind + 1);
            }
            else if (s[ind] == 'X')
            {
                Stack<char> tmp = st;

                tmp.Push(s[ind]);

                res = IsBalanced(s, tmp, ind + 1);

                if (res == 1)
                {
                    return 1;
                }

                if (st.Count == 0)
                {
                    return 0;
                }

                st.Pop();
                return IsBalanced(s, st, ind + 1);
            }

            return 1;
        }
    }
}
