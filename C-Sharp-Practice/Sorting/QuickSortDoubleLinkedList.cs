using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.Sorting
{
    public class QuickSortDoubleLinkedList
    {
        public NodeQs head;
        public void Sort(NodeQs node)
        {
            NodeQs head = LastNode(node);
            QuickSortSub(node, head);
        }

        public void Push(int data)
        {
            NodeQs newNode = new NodeQs(data);

            if (head == null)
            {
                head = newNode;
                return;
            }

            newNode.next = head;
            head.prev = newNode;
            newNode.prev = null;
            head = newNode;
        }

        NodeQs LastNode(NodeQs node)
        {
            while (node.next != null)
            {
                node = node.next;
            }

            return node;
        }


        NodeQs Partition(NodeQs l, NodeQs h)
        {
            int x = h.data;

            NodeQs i = l.prev;
            int temp;

            for (NodeQs j = l; j != h; j = j.next)
            {
                if (j.data <= x)
                {
                    i = i == null ? l : i.next;
                    temp = i.data;
                    i.data = j.data;
                    j.data = temp;
                }
            }

            i = i == null ? l : i.next;
            temp = i.data;
            i.data = h.data;
            h.data = temp;

            return i;
        }

        void QuickSortSub(NodeQs l, NodeQs h)
        {
            if (h != null && l != h && l != h.next)
            {
                NodeQs temp = Partition(l, h);
                QuickSortSub(l, temp.prev);
                QuickSortSub(temp.next, h);
            }
        }
    }

    public class NodeQs
    {
        public int data;
        public NodeQs next;
        public NodeQs prev;

        public NodeQs(int d)
        {
            this.data = d;
            next = null;
            prev = null;
        }
    }
}
