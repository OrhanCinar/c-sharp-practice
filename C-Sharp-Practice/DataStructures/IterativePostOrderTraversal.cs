using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.DataStructures
{
    public class Node
    {
        public int data;
        public Node left, right;

        public Node(int data)
        {
            this.data = data;
        }
    }

    public class IterativePostOrderTraversal
    {
        public Stack<Node> s1, s2;

        public void PostOrderIterative(Node root)
        {
            s1 = new Stack<Node>();
            s2 = new Stack<Node>();

            if (root == null)
            {
                return;
            }

            s1.Push(root);

            while (s1.Count > 0)
            {
                Node temp = s1.Pop();

                s2.Push(temp);

                if (temp.left != null)
                {
                    s1.Push(temp.left);
                }

                if (temp.right != null)
                {
                    s1.Push(temp.right);
                }
            }

            while (s2.Count > 0)
            {
                Node temp = s2.Pop();
                Console.Write(temp.data + " ");
            }
        }
    }
}
