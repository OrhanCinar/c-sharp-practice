using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class MaxSumSubArrayRemovingOneElement
    {
        int MaxSumSubarrayRemovingOneEle(int[] arr, int n)
        {
            int[] fw = new int[n];
            int[] bw = new int[n];

            int curr_max = arr[0], max_so_far = arr[0];

            fw[0] = arr[0];

            for (int i = 0; i < n; i++)
            {
                curr_max = Math.Max(arr[i], curr_max + arr[i]);
                max_so_far = Math.Max(max_so_far, curr_max);

                fw[i] = curr_max;
            }

            curr_max = max_so_far = bw[n - 1] = arr[n - 1];

            for (int i = n - 2; i >= 0; i--)
            {
                curr_max = Math.Max(arr[i], curr_max + arr[i]);
                max_so_far = Math.Max(max_so_far, curr_max);

                bw[i] = curr_max;
            }


            int fans = max_so_far;

            for (int i = 0; i < n - 1; i++)
            {
                fans = Math.Max(fans, fw[i - 1] + bw[i + 1]);
            }

            return fans;
        }
    }
}
