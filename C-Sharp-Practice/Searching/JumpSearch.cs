using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.Searching
{
    public class JumpSearch
    {
        public int Search(int[] arr, int x)
        {
            int n = arr.Length;

            int step = (int)Math.Floor(Math.Sqrt(n));

            int prev = 0;

            while (arr[Math.Min(step, n) - 1] < x)
            {
                prev = step;
                step += (int)Math.Floor(Math.Sqrt(n));
                if (prev >= n)
                {
                    return -1;
                }
            }

            while (arr[prev] < x)
            {
                prev++;

                if (prev == Math.Min(step, n))
                {
                    return -1;
                }
            }

            if (arr[prev] == x)
            {
                return prev;
            }

            return -1;
        }
    }
}
