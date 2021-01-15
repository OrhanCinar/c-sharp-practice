using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.DataStructures
{
    public class SortArrayWithStack
    {
        public Stack<int> Sort(Stack<int> input)
        {
            Stack<int> tmpStack = new Stack<int>();

            while (input.Count != 0)
            {
                int tmp = input.Peek();
                input.Pop();

                while(tmpStack.Count != 0 && tmpStack.Peek() < tmp)
                {
                    input.Push(tmpStack.Peek());
                    tmpStack.Pop();
                }

                tmpStack.Push(tmp);
            }


            return tmpStack;
        }


    }
}
