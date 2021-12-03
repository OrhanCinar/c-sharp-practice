using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class CountPossibleWaysConstructBuilding
    {
        int CountWays(int N)
        {
            if (N == 1)
            {
                return 4;
            }

            int countB = 1, countS = 1, prevcountB, prevcountS;

            for (int i = 2; i < N; i++)
            {
                prevcountB = countB;
                prevcountS = countS;

                countS = prevcountB + prevcountS;
                countB = prevcountS;
            }

            int result = countS + countB;

            return result * result;
        }
    }
}
