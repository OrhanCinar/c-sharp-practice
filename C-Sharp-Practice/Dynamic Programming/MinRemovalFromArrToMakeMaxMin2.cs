using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class MinRemovalFromArrToMakeMaxMin2
    {
        int FindInd(int key, int i,int n, int k, int[] arr)
        {
            int start, end, mid, ind = -1;
            start = i + 1;
            end = n - 1;

            while (start < end)
            {
                mid = start + (end - start) / 2;

                if (arr[mid] - k <= k)
                {
                    ind = mid;
                    start = mid + 1;
                }
                else
                {
                    end = mid;
                }
            }

            return ind;
        }

        int Removals(int[] arr, int n, int k)
        {
            int i, j, ans = n - 1;
          
            Array.Sort(arr);
            
            for (i = 0; i < n; i++)
            {
                j = FindInd(arr[i], i, n, k, arr);
                
                if (j != -1)
                {
                    ans = Math.Min(ans,n - (j - i + 1));
                }
            }
            
            return ans;
        }
    }
}
