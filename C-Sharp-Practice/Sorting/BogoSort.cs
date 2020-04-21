using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.Sorting
{
    public class BogoSort
    {
        public int[] Sort(int[] arr, int n)
        {
            while (!IsSorted(arr, n))
            {
                Shuffle(arr, n);
            }

            return arr;
        }

        private void Shuffle(int[] arr, int n)
        {
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                Swap(ref arr[i], ref arr[r.Next(0, n)]);
            }
        }

        private void Swap(ref int lhs, ref int rhs)
        {
            int tmp;

            tmp = lhs;
            lhs = rhs;
            rhs = tmp;
        }

        private bool IsSorted(int[] arr, int n)
        {
            int i = 0;

            while(i < n - 1)
            {
                if (arr[i]> arr[i + 1])
                {
                    return false;
                }
                i++;
            }


            return true;
        }
    }
}
