using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.Searching
{
    public class LinearSearch
    {
        public int Search(int[]arr , int x)
        {
            int n = arr.Length;

            for (int i = 0; i < n; i++)
            {
                if(arr[i] == x)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
