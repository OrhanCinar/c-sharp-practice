using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.DataStructures
{
    public class pair
    {
        public int first, second;

        public pair(int first, int second)
        {
            this.first = first;
            this.second = second;
        }
    }

    public class CountSubArrays
    {
        int MAXN = 100005;

        void MakeNext(int[] arr, int n, int[] nextBig)
        {
            Stack<pair> s = new Stack<pair>();

            for (int i = n - 1; i >= 0; i--)
            {
                nextBig[i] = i;

                while (s.Count != 0 && s.Peek().first < arr[i])
                {
                    s.Pop();
                }

                if (s.Count != 0)
                {
                    nextBig[i] = s.Peek().second;
                }

                s.Push(new pair(arr[i], i));
            }
        }

        void MakePrev(int[] arr, int n, int[] prevBig)
        {
            Stack<pair> s = new Stack<pair>();

            for (int i = 0; i < n; i++)
            {
                prevBig[i] = -1;

                while (s.Count != 0 && s.Peek().first < arr[i])
                {
                    s.Peek();
                }

                if (s.Count != 0)
                {
                    prevBig[i] = s.Peek().second;
                }

                s.Push(new pair(arr[i], i));
            }
        }

        public int Wrapper(int[] arr, int n)
        {
            int[] nextBig = new int[MAXN];
            int[] prevBig = new int[MAXN];
            int[] maxi = new int[MAXN];
            int ans = 0;


            MakePrev(arr, n, prevBig);

            MakeNext(arr, n, nextBig);


            for (int i = 0; i < n; i++)
            {
                if (nextBig[i] != i)
                {
                    maxi[nextBig[i] - 1] = Math.Max(maxi[nextBig[i] - 1], i - prevBig[i]);
                }
            }

            for (int i = 0; i < n; i++)
            {
                ans += maxi[i];
            }

            return ans;
        }
    }
}
