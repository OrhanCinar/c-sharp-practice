using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class HighEffortLowEffortTask2
    {
        int MaxTasks(int[] high, int[] low, int n)
        {
            int[] task_dp = new int[n + 1];
            task_dp[0] = 0;

            task_dp[1] = high[0];

            for (int i = 2; i <= n; i++)
            {
                task_dp[i] = Math.Max(high[i - 1] + task_dp[i - 2], low[i - 1] + task_dp[i - 1]);
            }

            return task_dp[n];
        }
    }
}
