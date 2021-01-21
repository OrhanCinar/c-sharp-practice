using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.DataStructures
{
    public class IterativePostOrderTraversalNode
    {
        public int data;
        public IterativePostOrderTraversalNode left, right;

        public IterativePostOrderTraversalNode(int item)
        {
            data = item;
            left = right;
        }
    }

    public class IterativePostOrderTraversal2
    {
        IterativePostOrderTraversalNode root;
        List<int> list = new List<int>();

        public List<int> IterativePostOrderTraversal(IterativePostOrderTraversalNode node)
        {
            Stack<IterativePostOrderTraversalNode> s = new Stack<IterativePostOrderTraversalNode>();

            if (node == null)
            {
                return list;
            }

            s.Push(node);

            IterativePostOrderTraversalNode prev = null;

            while (s.Count != 0)
            {
                IterativePostOrderTraversalNode current = s.Peek();

                if (prev == null || prev.left == current || prev.right == current)
                {
                    if (current.left != null)
                    {
                        s.Push(current.left);
                    }
                    else if (current.right != null)
                    {
                        s.Push(current.right);
                    }
                    else
                    {
                        s.Pop();
                        list.Add(current.data);
                    }
                }
                else if (current.left == prev)
                {
                    if (current.right != null)
                    {
                        s.Push(current.right);
                    }
                    else
                    {
                        s.Pop();
                        list.Add(current.data);
                    }
                }else if (current.right == prev)
                {
                    s.Pop();
                    list.Add(current.data);
                }

                prev = current;
            }

            return list;
        }
    }
}
