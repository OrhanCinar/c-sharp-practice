using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.DataStructures
{
    public class MaximumDepthNestedParenthesisString
    {
        public int MaxDepth(string s)
        {
            int current_max = 0;

            int max = 0;

            int n = s.Length;

            for (int i = 0; i < n; i++)
            {
                if (s[i] == '(')
                {
                    current_max++;

                    if (current_max > max)
                    {
                        max = current_max;
                    }
                }
                else if (s[i] == ')')
                {
                    if (current_max > 0)
                    {
                        current_max--;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }

            if (current_max != 0)
            {
                return -1;
            }

            return max;
        }
    }
}
