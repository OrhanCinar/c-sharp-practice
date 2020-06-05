using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.DataStructures
{
    public class NextGreaterElement
    {
        public void FindNextGreaterElement(int[] arr, int n)
        {
            int next, i, j;


            for (i = 0; i < n; i++)
            {
                next = -1;

                for (j = i + 1; j < n; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        next = arr[j];
                        break;
                    }
                }
            }
        }
    }
}
