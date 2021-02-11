using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.DataStructures
{
    public class BubbleSortTwoStack
    {
        public void BubbleSortStack(int[] arr, int n)
        {
            Stack<int> s1 = new Stack<int>();

            foreach (var num in arr)
            {
                s1.Push(num);
            }

            Stack<int> s2 = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    while (s1.Count != 0)
                    {
                        int t = s1.Pop();

                        if (s2.Count == 0)
                        {
                            s2.Push(t);
                        }
                        else
                        {
                            if (s2.Peek() > t)
                            {
                                int temp = s2.Pop();
                                s2.Push(t);
                                s2.Push(temp);
                            }
                            else
                            {
                                s2.Push(t);
                            }
                        }
                    }

                    arr[n - 1] = s2.Pop();
                }
                else
                {
                    while (s2.Count != 0)
                    {
                        int t = s2.Pop();

                        if (s1.Count == 0)
                        {
                            s2.Push(t);
                        }
                        else
                        {
                            if (s1.Peek() > t)
                            {
                                int temp = s1.Pop();

                                s1.Push(t);
                                s1.Push(temp);
                            }
                            else
                            {
                                s1.Push(t);
                            }
                        }
                    }

                    arr[n - 1 - i] = s1.Pop();
                }
            }

            Console.WriteLine("[" + string.Join(",", arr) + "]");
        }
    }
}
