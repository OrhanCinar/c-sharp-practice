using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.DataStructures
{
    public class FindMaxDiffLeftRight
    {
        void LefSmaller(int[] arr, int n, int[] SE)
        {
            Stack<int> st = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                while (st.Count != 0 && st.Peek() >= arr[i])
                {
                    st.Pop();
                }

                if (st.Count != 0)
                {
                    SE[i] = st.Peek();
                }
                else
                {
                    SE[i] = 0;
                }
                st.Push(arr[i]);
            }
        }

        public int FindMaxDiff(int[] arr, int n)
        {
            int[] LS = new int[n];

            LefSmaller(arr, n, LS);

            int[] RRS = new int[n];

            Reverse(arr);

            LefSmaller(arr, n, RRS);

            int result = -1;

            for (int i = 0; i < n; i++)
            {
                result = Math.Max(result, Math.Abs(LS[i] - RRS[n - 1 - i]));
            }

            return result;
        }

        private void Reverse(int[] arr)
        {
            int i, n = arr.Length;

            int t;

            for (i = 0; i < n / 2; i++)
            {
                t = arr[i];
                arr[i] = arr[n - i - 1];
                arr[n - i - 1] = t;
            }
        }
    }
}
