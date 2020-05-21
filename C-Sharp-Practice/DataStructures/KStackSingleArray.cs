using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.DataStructures
{
    public class KStackSingleArray
    {
        public int[] arr;
        public int[] top;
        public int[] next;

        public int n, k;
        public int free;
        public bool Full => free == -1;
        
        public KStackSingleArray(int k1, int n1)
        {
            k = k1;
            n = n1;
            arr = new int[n];
            top = new int[k];
            next = new int[n];
           
            for (int i = 0; i < k; i++)
            {
                top[i] = -1;
            }
            
            free = 0;
            for (int i = 0; i < n - 1; i++)
            {
                next[i] = i + 1;
            }
            next[n - 1] = -1;
        }

        public void Push(int item, int sn)
        {
            if (Full)
            {
                return;
            }

            int i = free;

            free = next[i];

            next[i] = top[sn];
            top[sn] = i;
            arr[i] = item;
        }

        public int Pop(int sn)
        {
            if (IsEmpty(sn))
            {
                return int.MaxValue;
            }

            int i = top[sn];
            top[sn] = next[i];
            next[i] = free;
            free = i;
            return arr[i];
        }

        private bool IsEmpty(int sn)
        {
            return top[sn] == -1;
        }
    }
}
