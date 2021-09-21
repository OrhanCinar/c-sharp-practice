using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    public class Temple
    {
        public int L;
        public int R;
    };

    class TempleOfferings2
    {
        int OfferingNumber(int n, int[] templeHeight)
        {
            Temple[] chainSize = new Temple[n];

            for (int i = 0; i < n; ++i)
            {
                chainSize[i] = new Temple();
                chainSize[i].L = -1;
                chainSize[i].R = -1;
            }

            chainSize[0].L = 1;
            chainSize[n - 1].R = 1;

            for (int i = 1; i < n; ++i)
            {
                if (templeHeight[i - 1] < templeHeight[i])
                {
                    chainSize[i].L = chainSize[i - 1].L + 1;
                }
                else
                {
                    chainSize[i].L = 1;
                }
            }

            for (int i = n - 2; i >= 0; --i)
            {
                if (templeHeight[i + 1] < templeHeight[i])
                {
                    chainSize[i].R = chainSize[i + 1].L + 1;
                }
                else
                {
                    chainSize[i].R = 1;
                }
            }

            int sum = 0;

            for (int i = 0; i < n; ++i)
            {
                sum += Math.Max(chainSize[i].L, chainSize[i].R);
            }

            return sum;
        }
    }
}
