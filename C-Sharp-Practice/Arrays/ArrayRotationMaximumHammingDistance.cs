using System;

namespace C_Sharp_Practice.Arrays
{
    public class ArrayRotationMaximumHammingDistance
    {
        public int GetMaximumHammingDistance(int[] arr, int n)
        {
            int[] doubleArr = new int[2 * n + 1];

            //copy array
            for (int i = 0; i < n; i++)
            {
                doubleArr[i] = arr[i];
                doubleArr[n + i] = arr[i];
            }

            int maxHamm = 0;


            for (int i = 1; i < n; i++)
            {
                int currHamm = 0;

                for (int j = i, k = 0; j < (i + n); j++, k++)
                {
                    if (doubleArr[j] != arr[k])
                    {
                        currHamm++;
                    }

                    if (currHamm == n)
                    {
                        return n;
                    }

                    maxHamm = Math.Max(maxHamm, currHamm);
                }
            }

            return maxHamm;
        }
    }
}
