using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.DataStructures
{
    public class FindIndexOfClosingBracket
    {
        public void FindIndex(string s, int index)
        {

            if (s[index] != '[')
            {
                Console.Write(s + ", " + index + " : -1");
            }


            Stack<int> st = new Stack<int>();
            int i;

            for (i = index; i < s.Length; i++)
            {
                if (s[i] == '[')
                {
                    st.Push(s[i]);
                }else if (s[i] == ']')
                {
                    st.Pop();
                    if(st.Count == 0)
                    {
                        Console.Write(s + ", " + index + " : "+ i);
                        return;
                    }
                }
            }

            Console.Write(s + ", " + index + " : -1");
        }
    }
}
