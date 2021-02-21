using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.DataStructures
{
    public class GrowableArrayBaseStack
    {
        int BOUND = 4;
        int top = -1;
        int length = 0;

        private int[] Create_New(int[] a)
        {
            int[] new_a = new int[length + BOUND];

            for (int i = 0; i < length; i++)
            {
                new_a[i] = a[i];
            }

            length += BOUND;
            return new_a;
        }


        public int[] Push(int[] a, int element)
        {
            if (top == length - 1)
            {
                a = Create_New(a);
            }

            a[++top] = element;
            return a;
        }

        public void Pop()
        {
            top--;
        }

        public void Display(int[] a)
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                Console.Write("Stack: ");

                for (int i = 0; i <= top; i++)
                {
                    Console.Write(a[i] + " ");                    
                }

                Console.WriteLine();
            }
        }
    }
}
