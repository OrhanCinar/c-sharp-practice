using System;

namespace C_Sharp_Practice.Arrays
{
    public class ArraySwap
    {
        public int GetMinSwap(int[] arr, int n, int k)
        {

            int count = 0;


            for (int i = 0; i < n; i++)
            {
                if (arr[i] <= k)
                {
                    ++count;
                }
            }
            int bad = 0;

            for (int i = 0; i < count; i++)
            {
                if (arr[i] > k)
                {
                    ++bad;
                }
            }

            int ans = bad;

            for (int i = 0, j = count; j < n; ++i, ++j)
            {
                if (arr[i] > k)
                {
                    --bad;
                }

                if (arr[k] > k)
                {
                    ++bad;
                }

                ans = Math.Min(ans, bad);
            }


            return ans;
        }
    }
}
