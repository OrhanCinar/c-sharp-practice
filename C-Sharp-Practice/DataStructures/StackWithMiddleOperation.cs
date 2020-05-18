using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.DataStructures
{
    public class StackWithMiddleOperation
    {


        public DLLStack CreateStack()
        {
            var myStack = new DLLStack();
            return myStack;
        }

        public void Push(DLLStack stack, int data)
        {
            DLLNode newNode = new DLLNode(data);

            newNode.prev = null;
            newNode.next = stack.head;

            stack.count++;

            if (stack.count == 1)
            {
                stack.mid = newNode;
            }
            else
            {
                stack.head.prev = newNode;

                if (stack.count % 2 != 0)
                {
                    stack.mid = stack.mid.prev;
                }
            }
        }


        public int Pop(DLLStack stack)
        {
            if (stack.count == 0)
            {
                return -1;
            }

            DLLNode head = stack.head;

            int item = head.data;
            stack.head = head.next;

            if (stack.head != null)
            {
                stack.head.prev = null;
            }

            stack.count--;

            if (stack.count % 2 != 0)
            {
                stack.mid = stack.mid.next;
            }

            return item;
        }

        public int FindMiddle(DLLStack stack)
        {
            if (stack.count == 0)
            {
                return -1;
            }

            return stack.mid.data;
        }
    }

    public class DLLStack
    {
        public DLLNode head { get; set; }
        public DLLNode mid { get; set; }
        public int count { get; set; }

    }

    public class DLLNode
    {
        public DLLNode prev { get; set; }
        public int data { get; set; }
        public DLLNode next { get; set; }

        public DLLNode(int d)
        {
            data = d;
        }
    }
}
