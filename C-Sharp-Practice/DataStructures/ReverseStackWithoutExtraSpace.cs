using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.DataStructures
{
    public class ReverseStackWithoutExtraSpace
    {
        class StackNode
        {
            public int data;
            public StackNode next;

            public StackNode(int data)
            {
                this.data = data;
                next = null;
            }
        }

        class Stack
        {
            public StackNode top;

            public void Push(int data)
            {
                if (this.top == null)
                {
                    top = new StackNode(data);
                    return;
                }

                StackNode s = new StackNode(data);
                s.next = this.top;
                this.top = s;
            }

            public StackNode Pop()
            {
                StackNode s = top;
                top = top.next;
                return s;
            }

            public void Display()
            {
                StackNode s = top;

                while(s != null)
                {
                    Console.Write(s.data + " ");
                    s = s.next;
                }

                Console.WriteLine();
            }

            public void Reverse()
            {
                StackNode prev, cur, succ;

                cur = prev = top;
                cur = cur.next;
                prev.next = null;

                while(cur != null)
                {
                    succ = cur.next;
                    cur.next = prev;
                    prev = cur;
                    cur = succ;
                }

                top = prev;
            }
        }

        public void ReverseStack()
        {
            Stack s = new Stack();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);
            
            s.Display();
            s.Reverse();
            s.Display();
        }
    }
}
