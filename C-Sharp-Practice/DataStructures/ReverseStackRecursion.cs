using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.DataStructures
{
    public class ReverseStackRecursion
    {
        Stack<char> st = new Stack<char>();

        public void ReverseStack()
        {
            if (st.Count > 0)
            {
                char x = st.Peek();
                st.Pop();
                ReverseStack();

                InsertAtBottom(x);
            }
        }

        public void Push(char x)
        {
            st.Push(x);
        }

        public Stack<char> GetStack()
        {
            return st;
        }

        void InsertAtBottom(char x)
        {
            if (st.Count == 0)
            {
                st.Push(x);
            }
            else
            {
                char a = st.Peek();
                st.Pop();
                InsertAtBottom(x);

                st.Push(a);
            }
        }
    }
}
