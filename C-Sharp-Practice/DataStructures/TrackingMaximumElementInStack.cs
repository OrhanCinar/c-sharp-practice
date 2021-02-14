using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.DataStructures
{
    public class TrackingMaximumElementInStack
    {
        Stack<int> mainStack = new Stack<int>();
        Stack<int> trackStack = new Stack<int>();

        public void Push(int x)
        {
            mainStack.Push(x);

            if (mainStack.Count == 1)
            {
                trackStack.Push(x);
                return;
            }

            if (x > trackStack.Peek())
            {
                trackStack.Push(x);
            }
            else
            {
                trackStack.Push(trackStack.Peek());
            }
        }

        public void Pop()
        {
            mainStack.Pop();
            trackStack.Pop();
        }

        public int GetMax()
        {
            return trackStack.Peek();
        }

    }
}
