using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class PartitionProblem3
    {
        bool FindPartiion(int[] arr, int n)
        {
            int sum = 0;
            int i, j;

            for (i = 0; i < n; i++)
            {
                sum += arr[i];
            }

            if (sum % 2 != 0)
            {
                return false;
            }

            bool[] part = new bool[sum / 2 + 1];

            for (i = 0; i < sum / 2; i++)
            {
                part[i] = false;
            }

            for (i = 0; i < n; i++)
            {
                for (j = sum / 2; j >= arr[i]; j--)
                {
                    if (part[j - arr[i]] || j == arr[i])
                    {
                        part[j] = true;
                    }
                }
            }

            return part[sum / 2];
        }
    }
}
