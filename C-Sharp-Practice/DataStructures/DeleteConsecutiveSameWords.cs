using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.DataStructures
{
    public class DeleteConsecutiveSameWords
    {
        public int RemoveConsecutiveSame(List<string> v)
        {
            int n = v.Count;

            for (int i = 0; i < n - 1; i++)
            {
                if (v[i].Equals(v[i + 1]))
                {
                    v.RemoveAt(i);
                    v.RemoveAt(i);

                    if (i > 0)
                    {
                        i--;
                    }

                    n = n - 2;

                }
                else
                {
                    i++;
                }
            }

            return v.Count;
        }
    }
}
