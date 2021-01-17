using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.DataStructures
{
    public class CheckQueueCanSorted
    {
        public bool CheckSorted(int n, ref Queue<int> q)
        {
            Stack<int> st = new Stack<int>();
            int expected = 1;
            int fnt;

            while (q.Count != 0)
            {
                fnt = q.Peek();
                q.Dequeue();

                if (fnt == expected)
                {
                    expected++;
                }
                else
                {
                    if (st.Count != 0)
                    {
                        st.Push(fnt);
                    }
                    else if (st.Count != 0 && st.Peek() < fnt)
                    {
                        return false;
                    }
                    else
                    {
                        st.Push(fnt);
                    }
                }

                while (st.Count != 0 && st.Peek() == expected)
                {
                    st.Pop();
                    expected++;
                }
            }

            if (expected - 1 == n && st.Count == 0)
            {
                return true;
            }

            return false;
        }
    }
}
