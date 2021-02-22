using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.DataStructures
{
    public class RangeQueriesForLongestCorrectBracket
    {
        public void ConstructBalanceArray(int[] BOP, int[] BCP, string str, int n)
        {
            Stack<int> st = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                if (str[i] == '(')
                {
                    st.Push(i);
                }
                else
                {
                    if (st.Count != 0)
                    {
                        BCP[i] = 1;
                        BOP[st.Peek()] = 1;
                        st.Pop();
                    }
                    else
                    {
                        BCP[i] = 0;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                BCP[i] += BCP[i - 1];
                BOP[i] += BOP[i - 1];
            }
        }

        public int Query(int[] BOP, int[] BCP, int s, int e)
        {
            if (BOP[s - 1] == BOP[s])
            {
                return (BCP[e] - BOP[s]) * 2;
            }
            else
            {
                return (BCP[e] - BOP[s] + 1) * 2;
            }
        }
    }
}
