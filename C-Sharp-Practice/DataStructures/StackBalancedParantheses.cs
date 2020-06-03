using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.DataStructures
{
    public class StackBalancedParantheses
    {

        bool IsMatchingPair(char character1, char character2)
        {
            if (character1 == '(' && character2 == ')')
            {
                return true;
            }

            if (character1 == '{' && character2 == '}')
            {
                return true;
            }

            if (character1 == '[' && character2 == ']')
            {
                return true;
            }

            return false;
        }

        public bool AreparanthesisBalances(char[] exp)
        {
            Stack<char> s = new Stack<char>();

            for (int i = 0; i < exp.Length; i++)
            {
                if (exp[i] == '{' || exp[i] == '(' || exp[i] == '[')
                {
                    s.Push(exp[i]);
                }

                if (exp[i] == '}' || exp[i] == ')' || exp[i] == ']')
                {
                    if (s.Count == 0)
                    {
                        return false;
                    }
                    
                    if (!IsMatchingPair(s.Pop(), exp[i]))
                    {
                        return false;
                    }
                }
            }

            return s.Count == 0;
        }
    }
}
