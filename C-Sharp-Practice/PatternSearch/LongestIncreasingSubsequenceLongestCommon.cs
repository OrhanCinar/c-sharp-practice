using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.PatternSearch
{
    public class LongestIncreasingSubsequenceLongestCommon
    {
        public int Search(List<int> sequence)
        {
            int n = sequence.Count;

            int[,] L = new int[n + 1, n + 1];
           
            List<int> sortedSeq = new List<int>(sequence);
            sortedSeq.Sort();

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= n ; j++)
                {
                    if (i == 0 ||j == 0)
                    {
                        L[i, j] = 0;
                    }else if (sequence[i-1] == sortedSeq[j - 1])
                    {
                        L[i, j] = L[i - 1, j - 1] + 1;
                    }else
                    {
                        L[i, j] = Math.Max(L[i - 1, j], L[i, j-1]);
                    }
                }
            }

            return L[n, n];
        }       
    }
}
