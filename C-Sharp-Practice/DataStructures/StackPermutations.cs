using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.DataStructures
{
    public class StackPermutations
    {
        public bool CheckStackPermutation(int[] ip, int[] op, int n)
        {
            Queue<int> input = new Queue<int>();

            for (int i = 0; i < n; i++)
            {
                input.Enqueue(ip[i]);
            }

            Queue<int> output = new Queue<int>();

            for (int i = 0; i < n; i++)
            {
                output.Enqueue(op[i]);
            }

            Stack<int> tempStack = new Stack<int>();

            while (input.Count != 0)
            {
                int ele = input.Dequeue();

                if (ele == output.Peek())
                {
                    output.Dequeue();

                    while (tempStack.Count != 0)
                    {
                        if (tempStack.Peek() == output.Peek())
                        {
                            tempStack.Pop();
                            output.Dequeue();
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    tempStack.Push(ele);
                }
            }

            return input.Count == 0 && tempStack.Count == 0;
        }
    }
}
