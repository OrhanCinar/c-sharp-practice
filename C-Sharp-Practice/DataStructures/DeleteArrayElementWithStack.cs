using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.DataStructures
{
    public class DeleteArrayElementWithStack
    {
        public void DeleteElement(int[] arr, int n , int k)
        {
            Stack<int> s = new Stack<int>();
            s.Push(arr[0]);

            int count = 0;

            for (int i = 1; i < n; i++)
            {
                while(s.Count != 0 && s.Peek() < arr[i] && count < k)
                {
                    s.Pop();
                    count++;
                }

                s.Push(arr[i]);
            }


            int m = s.Count;
            int[] v = new int[m];

            while(s.Count != 0)
            {
                v[--m] = s.Peek();
                s.Pop();
            }

            foreach (var x in v)
            {
                Console.Write(x + " ");
            }

            Console.Write("");

        }
    }
}
