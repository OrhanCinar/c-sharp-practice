using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace C_Sharp_Practice.DataStructures
{
    public class MaximumProductOfIndexNGLR
    {
        int MAX = 1000;

        public int Search(int[] arr, int n)
        {
            int[] left = NextGreaterInLeft(arr, n);
            int[] right = NextGreaterInRight(arr, n);
            int ans = -1;

            for (int i = 0; i <= n; i++)
            {
                ans = Math.Max(ans, left[i] * right[i]);
            }

            return ans;

        }

        private int[] NextGreaterInLeft(int[] a, int n)
        {
            int[] left_index = new int[MAX];

            Stack<int> s = new Stack<int>();

            for (int i = n - 1; i > 0; i--)
            {
                while (s.Count != 0 && a[i] > a[s.Peek() - 1])
                {
                    int r = s.Peek();
                    s.Pop();

                    left_index[r - 1] = i + 1;
                }

                s.Push(i + 1);
            }

            return left_index;
        }

        private int[] NextGreaterInRight(int[] a, int n)
        {
            int[] right_index = new int[MAX];
            Stack<int> s = new Stack<int>();

            for (int i = 0; i < n; ++i)
            {
                while (s.Count != 0 && a[i] > a[s.Peek() - 1])
                {
                    int r = s.Peek();
                    s.Pop();

                    right_index[r - 1] = i + 1;
                }

                s.Push(i + 1);
            }

            return right_index;
        }

    }
}
