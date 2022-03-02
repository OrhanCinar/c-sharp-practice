using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class MinTimeToFinishTask
    {
        int MinTime(int[] arr, int n)
        {
            if (n <= 0)
            {
                return 0;
            }

            int incl = arr[0];

            int excl = 0;

            for (int i = 1; i < n; i++)
            {
                int incl_new = arr[i] + Math.Min(excl, incl);
                int excl_new = incl;

                incl = incl_new;
                excl = excl_new;
            }

            return Math.Min(incl, excl);

        }
    }
}
