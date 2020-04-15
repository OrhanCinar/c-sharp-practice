using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.Sorting
{
    public class CocktailSort
    {
        public int[] Sort(int[] arr)
        {
            bool swapped = true;
            int start = 0;
            int end = arr.Length;


            while (swapped)
            {
                swapped = false;

                for (int i = start; i < end - 1; ++i)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        swapped = true;
                    }
                }


                if (!swapped)
                {
                    break;
                }

                swapped = false;

                end -= 1;

                for (int i = end - 1; i >= start; i--)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        swapped = true;
                    }
                }

                start += 1;

            }

            return arr;
        }
    }
}
