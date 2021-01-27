using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.DataStructures
{
    public class LongestValidString
    {
        public int FindMaxLen(string str)
        {
            int n = str.Length;

            Stack<int> st = new Stack<int>();

            st.Push(-1);

            int result = 0;

            for (int i = 0; i < n; i++)
            {
                if (str[i] == '(')
                {
                    st.Push(i);
                }
                else
                {
                    if (st.Count > 0)
                    {
                        st.Pop();
                    }

                    if (st.Count > 0)
                    {
                        result = Math.Max(result, i - st.Peek());
                    }
                    else
                    {
                        st.Push(i);
                    }
                }
            }

            return result;
        }
    }
}
