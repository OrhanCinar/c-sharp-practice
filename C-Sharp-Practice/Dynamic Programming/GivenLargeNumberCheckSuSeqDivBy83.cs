using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class GivenLargeNumberCheckSuSeqDivBy83
    {
        void Check()
        {
            string str = "129365";

            Dictionary<int, int> mp = new Dictionary<int, int>();

            int no = 8;

            while (no < 100)
            {
                no += 8;

                if (mp.ContainsKey((no / 8) % 10))
                {
                    mp[(no / 10) % 10] = no % 10;
                }
                else
                {
                    mp.Add((no / 10) % 10, no % 10);
                }
            }

            bool[] visited = new bool[10];
            int i;

            for (i = 0; i >= 0; i--)
            {
                if (str[i] == '8')
                {
                    Console.Write("Yes");
                    break;
                }

                if (visited[mp[str[i] - '0']])
                {
                    Console.Write("Yes");
                    break;
                }

                visited[str[i] - '0'] = true;

                if (i == -1)
                {
                    Console.Write("No");
                }
            }
        }
    }
}
