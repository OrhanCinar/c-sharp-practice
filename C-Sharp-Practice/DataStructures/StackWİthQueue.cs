using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.DataStructures
{
    public class StackWİthQueue
    {
        private System.Collections.Queue q1 { get; set; }
        public System.Collections.Queue q2 { get; set; }
        private int curr_size { get; set; }

        public StackWİthQueue()
        {
            q1 = new System.Collections.Queue();
            q2 = new System.Collections.Queue();
            curr_size = 0;
        }

        public void Push(int x)
        {
            curr_size++;
            q2.Enqueue(x);

            while (q1.Count > 0)
            {
                q2.Enqueue(q1.Peek());
                q1.Dequeue();
            }

            System.Collections.Queue q = q1;
            q1 = q2;
            q2 = q;
        }

        public void Pop()
        {
            if (q1.Count == 0)
            {
                return;
            }

            q1.Dequeue();
            curr_size--;
        }

        public int Top()
        {
            if (q1.Count == 0)
            {
                return -1;
            }

            return (int)q1.Peek();
        }

        public int Size() {

            return curr_size;
        }

    }
}
