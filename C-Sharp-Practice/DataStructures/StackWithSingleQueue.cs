using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.DataStructures
{
    public class StackWithSingleQueue
    {
        Queue<int> q = new Queue<int>();

        void Push(int val)
        {
            int size = q.Count;
            q.Enqueue(val);

            for (int i = 0; i < size; i++)
            {
                int x = q.Dequeue();
                q.Enqueue(x);
            }
        }

        int Pop()
        {
            if (q.Count == 0)
            {
                return -1;
            }

            int x = q.Dequeue();

            return x;
        }

        int Top()
        {
            if (q.Count == 0)
            {
                return -1;
            }

            return q.Peek();
        }

        bool IsEmpty()
        {
            return q.Count > 0;
        }
    }
}
