using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.DataStructures
{
    public class RedundantBracketCheck
    {
        public bool CheckRedundancy(string s)
        {
            Stack<char> st = new Stack<char>();
            char[] str = s.ToCharArray();

            foreach (var item in str)
            {
                if (item == ')')
                {
                    char top = st.Peek();
                    st.Pop();

                    bool flag = true;

                    while (top != ')')
                    {
                        if (top == '+' || top == '-' || top == '*' || top == '/')
                        {
                            flag = false;
                        }

                        top = st.Peek();
                        st.Pop();
                    }

                    if (flag)
                    {
                        return true;
                    }
                }
                else
                {
                    st.Push(item);
                }
            }


            return false;
        }
    }
}
