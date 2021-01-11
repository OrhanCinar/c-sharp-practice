using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTestProject.DataStructures
{
    public class SortStackRecursion
    {
        void SortedInsert(Stack<int>s, int x)
        {
            if (s.Count == 0 || x > s.Peek())
            {
                s.Push(x);
                return;
            }

            int temp = s.Peek();
            s.Pop();
            SortedInsert(s, x);

            s.Push(temp);
        }

        public void SortStack(Stack<int> s)
        {
            if (s.Count > 0)
            {
                int x = s.Peek();
                s.Pop();
                SortStack(s);

                SortedInsert(s, x);
            }
        }
    }
}
