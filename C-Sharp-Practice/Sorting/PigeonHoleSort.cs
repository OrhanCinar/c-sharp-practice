using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.Sorting
{
    public class PigeonHoleSort
    {
        public int[] Sort(int[] arr, int n)
        {

            int min = arr[0];
            int max = arr[0];
            int range, i, j, index;


            for (int a = 0; a < n; a++)
            {
                if (arr[a] > max)
                {
                    max = arr[a];
                }

                if (arr[a] < min)
                {
                    min = arr[a];
                }
            }


            range = max - min + 1;
            int[] phole = new int[range];

            for (i = 0; i < n; i++)
            {
                phole[i] = 0;
            }

            for (i = 0; i < n; i++)
            {
                phole[arr[i] - min]++;
            }

            index = 0;

            for (j = 0; j < range; j++)
            {
                while (phole[j]-- > 0)
                {
                    arr[index++] = j + min;
                }
            }



            return arr;
        }
    }
}
