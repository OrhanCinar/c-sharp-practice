using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class MinNumberDeletionMakeStringPalindrome2
    {
        int Delete(string str, int i, int j)
        {
            if (i >= j)
            {
                return 0;
            }


            if (str[i] == str[j])
            {
                return Delete(str, i + 1, j - 1);
            }

            return 1 + Math.Min(Delete(str, i + 1, j), Delete(str, i, j - 1));
        }

        int DeleteMinElement(string str)
        {
            return Delete(str, 0, str.Length - 1);
        }
    }
}
