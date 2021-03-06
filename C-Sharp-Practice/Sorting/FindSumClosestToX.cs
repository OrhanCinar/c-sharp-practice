using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.Sorting
{
    public class FindSumClosestToX
    {
        public void PrintClosest(int[] arr, int n, int x)
        {
            int res_l = 0, res_r = 0;

            int l = 0, r = n - 1, diff = int.MaxValue;

            while (r > l)
            {
                if (Math.Abs(arr[l]+ arr[r] - x) < diff)
                {
                    res_l = l;
                    res_r = r;
                    diff = Math.Abs(arr[l] + arr[r] - x);
                }

                if (arr[l] + arr[r] > x)
                {
                    r--;
                }
                else
                {
                    l++;
                }
            }

            Console.Write(" The closest pair is " + arr[res_l] + " and " + arr[res_r]);
        }
    }
}
