using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.DataStructures
{
    public class ReverseIndividualWords
    {
        public void ReverseWord(string str)
        {
            Stack<char> st = new Stack<char>();

            for (int i = 0; i < str.Length; ++i)
            {
                if(str[i] != ' ')
                {
                    st.Push(str[i]);
                }
                else
                {
                    while (st.Count > 0)
                    {
                        Console.Write(st.Pop());
                    }

                    Console.Write(" ");
                }
            }

            while(st.Count> 0)
            {
                Console.Write(st.Pop());
            }
        }
    }
}
