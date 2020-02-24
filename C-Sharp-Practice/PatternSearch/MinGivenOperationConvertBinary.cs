using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.PatternSearch
{
    public class MinGivenOperationConvertBinary
    {
        public int Convert(string str)
        {
            str = RemoveZerosFromFront(str);

            int i = ChangeToOnes(str);
            return i;
        }

        private string RemoveZerosFromFront(string str)
        {
            int i = 0;

            while (i < str.Length && str[i] == '0')
            {
                i++;
            }

            string s;
            if (i == str.Length)
            {
                s = "0";
            }
            else
            {
                s = str.Substring(i, str.Length - i);
            }

            return s;
        }

        private int ChangeToOnes(string str)
        {
            int i, l, ctr = 0;
            l = str.Length;

            for (i = l - 1; i >= 0; i--)
            {
                if (str[i] == '1')
                {
                    ctr++;
                }
                else
                {
                    break;
                }
            }

            return l - ctr;
        }

    }
}
