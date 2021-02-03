using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.DataStructures
{
    public class PreporderTraversalBinarySearchTree
    {
        public bool CanRepresentBts(int[] pre, int n)
        {
            Stack<int> s = new Stack<int>();

            int root = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                if (pre[i] < root)
                {
                    return false;
                }

                while(s.Count > 0 && s.Peek() < pre[i])
                {
                    root = s.Peek();
                    s.Pop();
                }

                s.Push(pre[i]);
            }
            
            return true;
        }
    }
}
