using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    public class LongestIncreasingSubsequence
    {
        int max_ref;
        public int GetLis(int[] arr, int n)
        {
            if (n == 1)
            {
                return 1;
            }

            int res, max_ending_here = 1;

            for (int i = 0; i < n; i++)
            {
                res = Lis(arr, i);

                if (arr[i - 1] < arr[n - 1] && res + 1 > max_ending_here)
                {
                    max_ending_here = res + 1;
                }
            }

            if (max_ref < max_ending_here)
            {
                max_ref = max_ending_here;
            }

            return max_ending_here;
        }

        private int Lis(int[] arr, int n)
        {
            max_ref = 1;
            Lis(arr, n);

            return max_ref;
        }
    }
}
