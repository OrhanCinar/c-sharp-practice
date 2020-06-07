using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.DataStructures
{
    public class NextGreaterFrequencyElementRight
    {
        public int GetGreater(int[] dp, int index)
        {
            return dp[index];
        }

        private void FillNext(int[] next, int[] a, int n)
        {
            Stack<int> s = new Stack<int>();

            s.Push(0);

            for (int i = 1; i < n; i++)
            {
                while (s.Count > 0)
                {
                    int cur = s.Peek();

                    if (a[cur] < a[i])
                    {
                        next[cur] = i;
                        s.Pop();
                    }
                    else
                    {
                        break;
                    }
                }

                s.Push(i);
            }

            while (s.Count > 0)
            {
                int cur = s.Peek();
                next[cur] = -1;
                s.Pop();
            }
        }

        public void Count(int[] a, int[] dp, int n)
        {
            int[] next = new int[n];
            for (int i = 0; i < n; i++)
            {
                next[i] = 0;
            }

            FillNext(next, a, n);

            for (int i = n - 2; i >= 0; i--)
            {
                if (next[i] == -1)
                {
                    dp[i] = 0;
                }
                else
                {
                    dp[i] = 1 + dp[next[i]];
                }
            }
        }
    }
}
