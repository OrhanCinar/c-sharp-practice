using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.DataStructures
{
    public class DecodeStringRecursivelyEncoded
    {
        public string Decode(string str)
        {
            Stack<int> intStack = new Stack<int>();
            Stack<char> strStack = new Stack<char>();
            string temp = "", result = "";


            for (int i = 0; i < str.Length; i++)
            {
                int count = 0;

                if (char.IsDigit(str[i]))
                {
                    while (char.IsDigit(str[i]))
                    {
                        count = count * 10 + str[i] - '0';
                        i++;
                    }

                    i--;
                    intStack.Push(count);
                }
                else if (str[i] == ']')
                {
                    temp = "";
                    count = 0;

                    if (intStack.Count > 0)
                    {
                        count = intStack.Peek();
                        intStack.Pop();
                    }

                    while (strStack.Count > 0 && strStack.Peek() != '[')
                    {
                        temp = strStack.Peek() + temp;
                        strStack.Pop();
                    }

                    if (strStack.Count > 0 && strStack.Peek() == '[')
                    {
                        strStack.Pop();
                    }

                    for (int j = 0; j < result.Length; j++)
                    {
                        strStack.Push(result[j]);
                    }

                    result = "";
                }
                else if (str[i] == '[')
                {
                    if (char.IsDigit(str[i - 1]))
                    {
                        strStack.Push(str[i]);
                    }
                    else
                    {
                        strStack.Push(str[i]);
                        intStack.Push(1);
                    }
                }
                else
                {
                    strStack.Push(str[i]);
                }
            }

            while (strStack.Count > 0)
            {
                result = strStack.Peek() + result;
                strStack.Pop();
            }

            return result;
        }
    }
}
