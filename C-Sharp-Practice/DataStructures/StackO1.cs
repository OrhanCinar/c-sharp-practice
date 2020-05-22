using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace C_Sharp_Practice.DataStructures
{
    public class StackO1
    {
        public Stack<int> s;
        public int minElement;

        public StackO1()
        {
            s = new Stack<int>();
        }

        public string GetMin()
        {
            if (s.Count == 0)
            {
                return "Stack is Empty";
            }
            else
            {
                return $"Min Element is Stack is {minElement}";
            }
        }

        public string Peek()
        {
            if (s.Count == 0)
            {
                return "Stack is Empty";
            }

            int t = s.Peek();

            if (t < minElement)
            {
                return minElement.ToString();
            }

            return t.ToString();
        }

        public string Pop()
        {
            if (s.Count == 0)
            {
                return "Stack is Empty";
            }

            int t = s.Pop();

            if (t < minElement)
            {
                minElement = 2 * minElement - t;
                return minElement.ToString();
            }

            return t.ToString();
        }

        public void Push(int x)
        {
            if (s.Count == 0)
            {
                minElement = x;
                s.Push(x);
                return;
            }

            if (x < minElement)
            {
                s.Push(2 * x - minElement);
                minElement = x;
            }
            else
            {
                s.Push(x);
            }
        }
    }
}
