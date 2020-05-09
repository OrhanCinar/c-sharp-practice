using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.Searching
{
    public class SublistSearch
    {
        public bool Search(SSNode first, SSNode second)
        {
            SSNode ptr1 = first;
            SSNode ptr2 = second;

            if (first == null && second == null)
            {
                return true;
            }

            if (first == null || (first != null && second == null))
            {
                return false;
            }

            while (second != null)
            {
                ptr2 = second;

                while (ptr1 != null)
                {
                    if (ptr2 == null)
                    {
                        return false;
                    }
                    else if (ptr1.data == ptr2.data)
                    {
                        ptr1 = ptr1.next;
                        ptr2 = ptr2.next;
                    }
                    else
                    {
                        break;
                    }
                }

                if (ptr1 == null)
                {
                    return true;
                }

                ptr1 = first;

                second = second.next;

            }

            return false;
        }

        public SSNode newNode(int key)
        {
            SSNode temp = new SSNode
            {
                data = key,
                next = null
            };
            return temp;
        }
    }

    public class SSNode
    {
        public int data;
        public SSNode next;
    }
}
