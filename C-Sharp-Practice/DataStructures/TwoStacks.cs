using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.DataStructures
{
    public class TwoStacks
    {
        public int size;
        public int top1, top2;
        public int[] arr;

        public TwoStacks(int n)
        {
            arr = new int[n];
            size = n;
            top1 = -1;
            top2 = size;
        }

        public void Push1(int x)
        {
            if (top1 < top2 - 1)
            {
                top1++;
                arr[top1] = x;
            }
            else
            {
                throw new StackOverflowException();
            }
        }

        public void Push2(int x)
        {
            if (top1 < top2 - 1)
            {
                top2--;
                arr[top2] = x;
            }
            else
            {
                throw new StackOverflowException();
            }
        }

        public int Pop1()
        {
            if (top1 >= 0)
            {
                int x = arr[top1];
                top1--;
                return x;
            }
            else
            {
                throw new StackOverflowException();
            }         
        }

        public int Pop2()
        {
            if (top2 < size)
            {
                int x = arr[top2];
                top2++;
                return x;
            }
            else
            {
                throw new StackOverflowException();
            }
        }
    }
}
