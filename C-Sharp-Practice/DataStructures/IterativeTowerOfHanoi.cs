using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.DataStructures
{
    public class Stack
    {
        public int capacity;
        public int top;
        public int[] array;
    }

    public class IterativeTowerOfHanoi
    {
        public Stack CreateStack(int capacity)
        {
            var stack = new Stack();
            stack.capacity = capacity;
            stack.top = -1;
            stack.array = new int[capacity];
            return stack;
        }

        bool IsFull(Stack stack)
        {
            return stack.top == stack.capacity - 1;
        }


        bool IsEmpty(Stack stack)
        {
            return stack.top == -1;
        }

        void Push(Stack stack, int item)
        {
            if (IsFull(stack))
            {
                return;
            }

            stack.array[++stack.top] = item;
        }
        int Pop(Stack stack)
        {
            if (IsEmpty(stack))
            {
                return int.MinValue;
            }
            return stack.array[stack.top--];
        }

        void MoveDisksBetweenTwoPoles(Stack src, Stack dest, char s, char d)
        {
            int pole1Top = Pop(src);
            int pole2Top = Pop(dest);

            if (pole1Top == int.MinValue)
            {
                Push(src, pole2Top);
                MoveDisk(d, s, pole2Top);
            }
            else if (pole2Top == int.MinValue)
            {
                Push(dest, pole1Top);
                MoveDisk(s, d, pole1Top);
            }
            else if (pole1Top > pole2Top)
            {
                Push(src, pole1Top);
                Push(src, pole2Top);
                MoveDisk(d, s, pole2Top);
            }
            else
            {
                Push(dest, pole2Top);
                Push(dest, pole1Top);
                MoveDisk(s, d, pole1Top);
            }
        }

        private void MoveDisk(char fromPeg, char toPeg, int disk)
        {
            Console.WriteLine($"Move the disk {disk} from {fromPeg} to {toPeg}");
        }

        public void TohIterative(int num_of_disks, Stack src, Stack aux, Stack dest)
        {
            int i, total_num_of_moves;
            char s = 'S', d = 'D', a = 'A';

            if (num_of_disks % 2 == 0)
            {
                char temp = d;
                d = a;
                a = temp;
            }

            total_num_of_moves = (int)(Math.Pow(2, num_of_disks) - 1);

            for (i = 0; i < total_num_of_moves; i++)
            {
                if (i % 3 == 1)
                {
                    MoveDisksBetweenTwoPoles(src, dest, s, d);
                }
                else if (i % 3 == 2)
                {
                    MoveDisksBetweenTwoPoles(src, aux, s, a);
                }
                else if (i % 3 == 0)
                {
                    MoveDisksBetweenTwoPoles(aux, dest, a, d);
                }
            }
        }
    }
}
