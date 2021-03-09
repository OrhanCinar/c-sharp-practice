using System;

namespace C_Sharp_Practice.Sorting
{
    public class ActivitySelectionProblem
    {
        public void PrintMaxActivities(int[] s, int[] f, int n)
        {
            int i, j;

            Console.Write("Following activities are selected : ");

            i = 0;

            Console.Write(i + " ");

            for (j = 0; j < n; j++)
            {
                if (s[j] >= f[i])
                {
                    Console.Write(j + " ");
                    i = j;
                }
            }
        }
    }
}
