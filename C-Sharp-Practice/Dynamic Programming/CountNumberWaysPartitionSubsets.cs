using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class CountNumberWaysPartitionSubsets
    {
        int CountP(int n, int k)
        {
            if (n == 0 || k == 0 || k > n)
            {
                return 0;
            }

            if (k == 1 || k == n)
            {
                return 1;
            }

            return (k * CountP(n - 1, k) + CountP(n - 1, k - 1);
        }
    }
}
