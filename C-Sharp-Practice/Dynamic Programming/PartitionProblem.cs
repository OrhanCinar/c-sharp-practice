using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class PartitionProblem
    {
        private bool IsSubsetSum(int[] arr, int n, int sum)
        {
            if (sum == 0)
            {
                return true;
            }

            if (n == 0 && sum != 0)
            {
                return false;
            }

            if (arr[n - 1] > sum)
            {
                return IsSubsetSum(arr, n - 1, sum);
            }

            return IsSubsetSum(arr, n - 1, sum) || IsSubsetSum(arr, n - 1, sum - arr[arr[n - 1]]);
        }

        public bool FindPartition(int[] arr, int n)
        {
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += arr[i];
            }

            if (sum % 2 != 0)
            {
                return false;
            }

            return IsSubsetSum(arr, n, sum / 2);
        }
    }
}
