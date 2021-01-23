using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.DataStructures
{
    public class AncestorBinaryTreeNoRecursion
    {
        public class BNode
        {
            public int data;
            public BNode left, right;

            public BNode(int data)
            {
                this.data = data;
            }
        }

        public void PrintAcestors(BNode root, int key)
        {
            if (root == null)
            {
                return;
            }

            Stack<BNode> st = new Stack<BNode>();

            while (true)
            {
                while(root != null && root.data != key)
                {
                    st.Push(root);
                    root = root.left;
                }

                if (root != null && root.data == key)
                {
                    break;
                }

                if (st.Peek().right == null)
                {
                    root = st.Peek();
                    st.Pop();

                    while(st.Count > 0 && st.Peek().right == root)
                    {
                        root = st.Peek();
                        st.Pop();
                    }
                }

                root = st.Count == 0 ? null : st.Peek().right;
            }

            while (st.Count > 0)
            {
                Console.Write(st.Peek().data + " ");
                st.Pop();
            }
        }
    }
}
