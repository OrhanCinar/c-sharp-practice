using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class FindStringIsPalidrome
    {
        int IsKPalRec(String str1, String str2, int m, int n)
        {
            if (m == 0)
            {
                return n;
            }

            if (n == 0)
            {
                return m;
            }

            if (str1[m - 1] == str2[n - 1])
            {
                return IsKPalRec(str1, str2, m - 1, n - 1);
            }

            return 1 + Math.Min(IsKPalRec(str1, str2, m - 1, n), IsKPalRec(str1, str2, m, n - 1));
        }

        bool IsKPal(String str, int k)
        {
            string revStr = str;
            revStr = Reverse(revStr);
            int len = str.Length;

            return IsKPalRec(str, revStr, len, len) <= k * 2;
        }

        private string Reverse(string input)
        {
            char[] tempArray = input.ToCharArray();
            int left, right = 0;

            right = tempArray.Length - 1;

            for (left = 0; left < right; left++, right--)
            {
                char temp = tempArray[left];
                tempArray[left] = tempArray[right];
                tempArray[right] = temp;
            }

            return string.Join("", tempArray);
        }
    }
}
