using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class HighEffortLowEffortTask
    {
        int MaxTasks(int[] high, int[] low, int n)
        {
            if (n <= 0)
            {
                return 0;
            }

            return Math.Max(high[n - 1] + MaxTasks(high, low, (n - 2)), low[n - 1] + MaxTasks(high, low, (n - 1)));
        }
    }
}
