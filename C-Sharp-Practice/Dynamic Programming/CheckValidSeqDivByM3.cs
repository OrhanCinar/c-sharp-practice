using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class CheckValidSeqDivByM3
    {
        void Func(int n, int m, int[] A)
        {
            List<int> modArray = new List<int>();

            for (int i = 0; i < n; i++)
            {
                modArray.Add(0);
            }

            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                modArray[i] = A[i] % m;
                sum += (int)modArray[i];
            }

            sum = sum % m;

            if (sum % m == 0)
            {
                Console.WriteLine("True");
                return;
            }

            if (sum % 2 != 0)
            {
                Console.WriteLine("False");
            }
            else
            {
                modArray.Remove(0);
                int i = 0;
                int j = modArray.Count - 1;

                modArray.Sort();

                sum = sum / 2;

                int i1, i2;

                while (i <= j)
                {
                    int s = (int)modArray[i] + (int)modArray[j];

                    if (s == sum)
                    {
                        i1 = i;
                        i2 = j;
                        Console.WriteLine("True");
                        break;
                    }

                    else if (s > sum)
                    {
                        j--;
                    }
                    else
                    {
                        i++;
                    }
                }
            }
        }
    }
}
