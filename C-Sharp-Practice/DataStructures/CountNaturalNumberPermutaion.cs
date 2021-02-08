using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.DataStructures
{
    public class CountNaturalNumberPermutaion
    {
        int CountNumber(int n)
        {
            int result = 0;
            Stack<int> s = new Stack<int>();


            for (int i = 0; i <= 9; i++)
            {
                if (i <= n)
                {
                    s.Push(i);
                    result++;
                }

                while (s.Count != 0)
                {
                    int tp = s.Peek();
                    s.Pop();

                    for (int j = tp % 10; j <= 9; j++)
                    {
                        int x = tp * 10 + j;
                        if (x <= n)
                        {
                            s.Push(x);
                            result++;
                        }
                    }
                }
            }

            return result;
        }
    }
}
