using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C_Sharp_Practice.DataStructures
{
    public class NextGreaterFrequencyElement
    {
        public string FindNextGreaterFrequency(int[] a, int n, int[] freq)
        {
            var sb = new StringBuilder();

            Stack<int> s = new Stack<int>();
            s.Push(0);

            int[] res = new int[n];


            for (int i = 0; i < n; i++)
            {
                res[i] = 0;
            }

            for (int i = 1; i < n; i++)
            {
                if (freq[a[s.Peek()]] > freq[a[i]])
                {
                    s.Push(i);
                }
                else
                {
                    while (freq[a[s.Peek()]] < freq[a[i]] && s.Count > 0)
                    {
                        res[s.Peek()] = a[i];
                        s.Pop();
                    }

                    s.Push(i);
                }
            }

            while (s.Count > 0)
            {
                res[s.Peek()] = -1;
                s.Pop();
            }

            for (int i = 0; i < n; i++)
            {
                sb.Append(res[i] + ",");
            }

            return sb.ToString();
        }
    }
}
