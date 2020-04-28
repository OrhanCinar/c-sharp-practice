using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.Sorting
{
    public class QuickSortSingleLinkedList
    {
        QuickNode PartitionLast(QuickNode start, QuickNode end)
        {
            if (start == end || start == null || end == null)
            {
                return start;
            }

            QuickNode pivot_prev = start;
            QuickNode curr = start;
            int pivot = end.data;

            int temp;


            while (start != end)
            {
                if (start.data < pivot)
                {
                    pivot_prev = curr;
                    temp = curr.data;
                    curr.data = start.data;
                    start.data = temp;
                    curr = curr.next;
                }

                start = start.next;
            }


            temp = curr.data;
            curr.data = pivot;
            end.data = temp;

            return pivot_prev;

        }


        public QuickNode Sort(QuickNode start, QuickNode end)
        {

            if (start == end)
                return start;

            QuickNode pivot_prev = PartitionLast(start, end);
            Sort(start, pivot_prev);


            if (pivot_prev != null && pivot_prev == start)
            {
                Sort(pivot_prev.next, end);
            }
            else if (pivot_prev != null && pivot_prev.next != null)
            {
                Sort(pivot_prev.next.next, end);
            }

            return start;
        }


        public QuickNode head;
        public void addNode(int data)
        {
            if (head == null)
            {
                head = new QuickNode(data);
                return;
            }

            QuickNode curr = head;

            while (curr.next != null)
            {
                curr = curr.next;
            }

            QuickNode newNode = new QuickNode(data);
            curr.next = newNode;

        }




        public class QuickNode
        {
            public int data;
            public QuickNode next;

            public QuickNode(int d)
            {
                data = d;
                next = null;
            }
        }

    }

}
