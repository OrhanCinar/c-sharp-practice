using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.Sorting
{
    public class GnomeSort
    {
        public int[]Sort(int[] arr, int n)
        {
            int index = 0;

            while (index<n)
            {
                if(index == 0)
                {
                    index++;
                }

                if (arr[index] >= arr[index - 1])
                {
                    index++;
                }else
                {
                    int temp = 0;
                    temp = arr[index];
                    arr[index] = arr[index - 1];
                    arr[index - 1] = temp;
                    index--;
                }
            }

            return arr;
        }
    }
}
