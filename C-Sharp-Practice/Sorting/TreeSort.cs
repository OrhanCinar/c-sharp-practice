using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.Sorting
{
    public class TreeSort
    {
        Node root;
        List<int> array = new List<int>();

        public int[] Sort(int[] arr)
        {
          

            for (int i = 0; i < arr.Length; i++)
            {
                Insert(arr[i]);
            }

            InorderRecord(root);

            return array.ToArray();
        }

        private void InorderRecord(Node root)
        {
            if (root != null)
            {
                InorderRecord(root.left);
                array.Add(root.key);
                InorderRecord(root.right);
            }
        }

        void Insert(int key)
        {
            root = InsertRecord(root, key);
        }

        private Node InsertRecord(Node root, int key)
        {
            if (root == null)
            {
                root = new Node(key);
                return root;
            }

            if (key < root.key)
            {
                root.left = InsertRecord(root.left, key);
            }
            else if (key > root.key)
            {
                root.right = InsertRecord(root.right, key);
            }

            return root;
        }
    }

    internal class Node
    {
        public int key;
        public Node left, right;

        public Node(int item)
        {
            key = item;
        }
    }
}
