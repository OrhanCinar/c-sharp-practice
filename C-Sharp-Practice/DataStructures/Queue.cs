using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.DataStructures
{
    public class Queue
    {
        public Stack<int>  stack1 { get; set; }
        public Stack<int> stack2 { get; set; }

        public Queue()
        {
            stack1 = new Stack<int>();
            stack2 = new Stack<int>();
        }

        public void EnQueue(int x)
        {
            while (stack1.Count> 0)
            {
                stack2.Push(stack1.Pop());
            }

            stack1.Push(x);

            while (stack2.Count>0)
            {
                stack1.Push(stack1.Pop());
            }
        }

        public int DeQueue()
        {
            int x = (int)stack1.Peek();
            stack1.Pop();
            return x;
        }
    }
}
