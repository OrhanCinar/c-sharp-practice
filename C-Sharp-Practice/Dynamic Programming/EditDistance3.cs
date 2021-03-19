using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.DynamicProgramming
{
    public class EditDistance3
    {
        public void EditDispDP(string s1, string s2)
        {
            int len1 = s1.Length;
            int len2 = s2.Length;

            int[,] DP = new int[2, len1 + 1];

            for (int i = 0; i < len2; i++)
            {
                for (int j = 0; j < len1; j++)
                {
                    if (j == 0)
                    {
                        DP[i % 2, j] = i;
                    }
                    else if (s1[j - 1] == s2[i - 1])
                    {
                        DP[i % 2, j] = DP[(i - 1) % 2, j - 1];
                    }
                    else
                    {
                        DP[i % 2, j] = 1 + Math.Min(DP[(i - 1) % 2, j], Math.Min(DP[i % 2, j - 1], DP[(i - 1) % 2, j - 1]));
                    }
                }
            }

            Console.Write(DP[len2 % 2, len1] + "\n");
        }
    }
}
