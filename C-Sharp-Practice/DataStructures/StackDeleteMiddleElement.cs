using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.DataStructures
{
    public class StackDeleteMiddleElement
    {
        void DeleteMid(Stack<char> st, int n, int curr = 0)
        {
            if (st.Count == 0 || curr == null)
            {
                return;
            }

            char x = st.Peek();
            st.Pop();

            DeleteMid(st, n, curr + 1);

            if (curr != n / 2)
            {
                st.Push(x);
            }
        }
    }
}
