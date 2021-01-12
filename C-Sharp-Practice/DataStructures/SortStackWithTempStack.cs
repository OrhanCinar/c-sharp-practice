using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.DataStructures
{
    public class SortStackWithTempStack
    {
        public Stack<int> SortStack(Stack<int> s)
        {
            Stack<int> tmpStack = new Stack<int>();

            while (s.Count > 0)
            {
                var tmp = s.Pop();

                while(tmpStack.Count > 0 && tmpStack.Peek() > tmp)
                {
                    s.Push(tmpStack.Pop());
                }

                tmpStack.Push(tmp);
            }

            return tmpStack;
        }
    }
}
