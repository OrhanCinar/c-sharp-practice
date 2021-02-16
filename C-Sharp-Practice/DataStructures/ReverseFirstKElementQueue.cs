using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.DataStructures
{
    public class ReverseFirstKElementQueue
    {
        LinkedList<int> queue;

        public void ReverseQueueFİrstKElement(int k)
        {
            if (queue.Count == 0 || k > queue.Count)
            {
                return;
            }

            if (k <= 0)
            {
                return;
            }

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < k; i++)
            {
                stack.Push(queue.First.Value);
                queue.RemoveFirst();
            }

            while(stack.Count > 0)
            {
                queue.AddLast(stack.Peek());
                stack.Pop();
            }

            for (int i = 0; i < queue.Count-k; i++)
            {
                queue.AddLast(queue.First.Value);

                queue.RemoveFirst();
            }
        }
    }
}
