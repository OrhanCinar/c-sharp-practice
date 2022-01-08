using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class MaxArrayElementsUptoGivenNumber
    {
        void FindMaxValUtil(int[] arr, int n, int num, int maxLimit, int ind, ref int ans)
        {
            if (ind == n)
            {
                ans = Math.Max(ans, num);
                return;
            }

            if (num - arr[ind] >= 0)
            {
                FindMaxValUtil(arr, n, num - arr[ind], maxLimit, ind + 1, ref ans);
            }

            if (num + arr[ind] <= maxLimit)
            {
                FindMaxValUtil(arr, n, num + arr[ind], maxLimit, ind + 1, ref ans);
            }
        }

        int FindMaxVal(int[] arr, int n, int num, int maxLimit)
        {
            int ans = 0;
            int ind = 0;

            FindMaxValUtil(arr, n, num, maxLimit, ind, ref ans);

            return ans;
        }
    }
}
