using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.DataStructures
{
    public class ReverseQueue
    {
        LinkedList<int> queue = new LinkedList<int>();

        public void Reverse()
        {
            Stack<int> stack = new Stack<int>();

            while(queue.Count > 0)
            {
                stack.Push(queue.First.Value);
                queue.RemoveFirst();
            }

            while(stack.Count > 0)
            {
                queue.AddLast(stack.Peek());
                stack.Pop();
            }
        }
    }
}
