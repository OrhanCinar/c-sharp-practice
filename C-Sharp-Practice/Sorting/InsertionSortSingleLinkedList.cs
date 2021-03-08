using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.Sorting
{
    public class InsertionSortSingleLinkedList
    {
        public INode head;
        public INode sorted;

        public class INode
        {
            public int val;
            public INode next;

            public INode(int val)
            {
                this.val = val;
            }
        }

        public void Push(int val)
        {
            INode newNode = new INode(val);
            newNode.next = head;
            head = newNode;
        }

        public void InsertionSort(INode headref)
        {
            sorted = null;

            INode current = headref;

            while(current != null)
            {
                INode next = current.next;

                SortedInsert(current);

                current = next;
            }

            head = sorted;
        }

        private void SortedInsert(INode newNode)
        {
            if (sorted == null ||sorted.val >= newNode.val)
            {
                newNode.next = sorted;
                sorted = newNode;
            }
            else
            {
                INode current = sorted;

                while(current.next != null && current.next.val < newNode.val)
                {
                    current = current.next;
                }

                newNode.next = current.next;
                current.next = newNode;

            }
        }

        void printlist(INode head)
        {
            while (head != null)
            {
                Console.Write(head.val + " ");
                head = head.next;
            }
        }
    }
}
