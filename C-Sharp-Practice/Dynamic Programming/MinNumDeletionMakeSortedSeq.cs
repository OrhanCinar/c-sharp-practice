using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class MinNumDeletionMakeSortedSeq
    {
        int Lis(int[] arr, int n)
        {
            int result = 0;
            int[] lis = new int[n];

            for (int i = 0; i < n; i++)
            {
                lis[i] = 1;
            }


            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] > arr[j] && lis[i] < lis[j] + 1)
                    {
                        lis[i] = lis[j] + 1;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                if(result < lis[i])
                {
                    result = lis[i];
                }
            }

            return result;
        }

        int MinimumNumberOfDeletions(int[] arr, int n)
        {
            int len = Lis(arr, n);
            
            return (n - len);
        }
    }
}
