using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.DataStructures
{
    public class NextGreaterNumberQQuery
    {
        public int[] Query(int[] arr, int[] query)
        {
            int[] ans = new int[arr.Length];

            Stack<int> s = new Stack<int>();

            s.Push(arr[0]);
            int j = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                int next = arr[i];

                if(s.Count > 0)
                {
                    int element = s.Pop();

                    while(next > element)
                    {
                        ans[j] = next;
                        j++;

                        if (s.Count == 0)
                        {
                            break;
                        }
                        element = s.Pop();
                    }



                    if (element > next)
                    {
                        s.Push(element);
                    }
                }

                s.Push(next);
            }

            while (s.Count > 0)
            {
                s.Pop();
                ans[j] = -1;
                j++;
            }

            return ans;
        }
    }
}
