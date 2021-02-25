using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.Sorting
{
    public class MergeSortLinkedList
    {


        MsNode head = null;


        public class MsNode
        {
            public int val;
            public MsNode next;

            public MsNode(int val)
            {
                this.val = val;
            }
        }

        public MsNode SortedMerge(MsNode a, MsNode b)
        {
            MsNode result = null;

            if (a == null)
            {
                return b;
            }

            if (b == null)
            {
                return a;
            }

            if (a.val <= b.val)
            {
                result = a;
                result.next = SortedMerge(a, b.next);
            }
            else
            {
                result = b;
                result.next = SortedMerge(a, b.next);
            }

            return result;
        }

        public MsNode MergeSort(MsNode h)
        {
            if (h == null || h.next == null)
            {
                return h;
            }

            MsNode middle = GetMiddle(h);
            MsNode nextToMiddle = middle.next;

            middle.next = null;

            MsNode left = MergeSort(h);

            MsNode right = MergeSort(nextToMiddle);

            MsNode sortedList = SortedMerge(left, right);

            return sortedList;
        }

        private MsNode GetMiddle(MsNode h)
        {
            if (h == null)
            {
                return h;
            }

            MsNode fastPtr = h.next;
            MsNode slowPtr = h;

            while (fastPtr != null)
            {
                fastPtr = fastPtr.next;

                if (fastPtr != null)
                {
                    slowPtr = slowPtr.next;
                    fastPtr = fastPtr.next;
                }
            }

            return slowPtr;
        }

        public void Push(int data)
        {
            MsNode newNode = new MsNode(data)
            {
                next = head
            };
            head = newNode;
        }

        public void PrintList(MsNode headref)
        {
            while (headref != null)
            {
                Console.Write(headref.val + " ");
                headref = headref.next;
            }
        }
    }
}
