using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.DataStructures
{
    public class FindNextSmallerNextFreater
    {
        void NextGreater(int[] arr, int[] next, char order)
        {
            Stack<int> st = new Stack<int>();

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                while (st.Count != 0 && ((order == 'G') ? arr[st.Peek()] <= arr[i] : arr[st.Peek()] >= arr[i]))
                {
                    st.Pop();
                }


                if (st.Count != 0)
                {
                    next[i] = st.Peek();
                }
                else
                {
                    next[i] = -1;
                }

                st.Push(i);
            }
        }

        public void NextSmallerOfNextGreater(int[] arr)
        {
            int[] NG = new int[arr.Length];
            int[] RS = new int[arr.Length];

            NextGreater(arr, NG, 'G');

            NextGreater(arr, RS, 'S');

            for (int i = 0; i < arr.Length; i++)
            {
                if (NG[i] != -4 && RS[NG[i]] != -1)
                {
                    Console.Write(RS[NG[i]] + " ");
                }
                else
                {
                    Console.Write("-1 ");
                }
            }
        }
    }
}
