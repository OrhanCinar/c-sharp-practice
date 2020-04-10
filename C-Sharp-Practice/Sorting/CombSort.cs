using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.Sorting
{
    public class CombSort
    {
        public int[] Sort(int[] arr)
        {
            int n = arr.Length;
            int gap = n;


            bool swapped = true;


            while (gap != 1 || swapped)
            {
                gap = getNextGap(gap);

                swapped = false;

                for (int i = 0; i < n - gap; i++)
                {
                    if (arr[i] > arr[i + gap])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + gap];
                        arr[i + gap] = temp;


                        swapped = true;
                    }
                }

            }


            return arr;
        }

        private int getNextGap(int gap)
        {
            gap = (gap * 10) / 13;

            return gap < 1 ? 1 : gap;
        }
    }
}
