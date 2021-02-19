using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.DataStructures
{
    public class InterleaveFirstHalfWithSecondHalf
    {
        public void InterLeaveQueue(Queue<int> q)
        {
            if (q.Count % 2 != 0)
            {
                Console.WriteLine("Input even number of integers.");
            }

            Stack<int> s = new Stack<int>();

            int halfSize = q.Count / 2;

            for (int i = 0; i < halfSize; i++)
            {
                s.Push(q.Peek());
                q.Dequeue();
            }

            while(s.Count !=0)
            {
                q.Enqueue(s.Peek());
                s.Pop();
            }

            for (int i = 0; i < halfSize; i++)
            {
                q.Enqueue(q.Peek());
                q.Dequeue();
            }

            for (int i = 0; i < halfSize; i++)
            {
                s.Push(q.Peek());
                q.Dequeue();
            }

            while(s.Count != 0)
            {
                q.Enqueue(s.Peek());
                s.Pop();
                q.Enqueue(q.Peek());
                q.Dequeue();
            }
        }
    }
}
