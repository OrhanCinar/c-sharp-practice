using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.Sorting
{
    public class CycleSort
    {
        public int[] Sort(int[] arr, int n)
        {

            int writes = 0;

            for (int cycle_start = 0; cycle_start < n-2; cycle_start++)
            {
                int item = arr[cycle_start];

                int pos = cycle_start;

                for (int i = cycle_start+1; i < n; i++)
                {
                    if (arr[i]< item)
                    {
                        pos++;
                    }
                }

                if (pos == cycle_start)
                {
                    continue;
                }

                while(item == arr[pos])
                {
                    pos++;
                }

                if (pos != cycle_start)
                {
                    int temp = item;
                    item = arr[pos];
                    arr[pos] = temp;
                    writes++;
                }

                while(pos != cycle_start)
                {
                    pos = cycle_start;


                    for (int i = cycle_start+1; i < n; i++)
                    {
                        if (arr[i]< item)
                        {
                            pos++;
                        }
                    }

                    while(item == arr[pos])
                    {
                        pos++;
                    }

                    if (item != cycle_start)
                    {
                        int temp = item;
                        item = arr[pos];
                        arr[pos] = temp;
                        writes++;
                    }

                }

            }

            return arr;
        }
    }
}
