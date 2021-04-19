using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    public class SubSetSumProblem
    {
        public bool IsSubsetSum(int[] set, int n, int sum)
        {
            if (sum == 0)
            {
                return true;
            }

            if (n == 0)
            {
                return false;
            }

            if (set[n - 1] > sum)
            {
                return IsSubsetSum(set, n - 1, sum);
            }

            return IsSubsetSum(set, n - 1, sum) || IsSubsetSum(set, n - 1, sum - set[n - 1]);
        }
    }
}
