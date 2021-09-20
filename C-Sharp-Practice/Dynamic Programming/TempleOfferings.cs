using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class TempleOfferings
    {
        int OfferingNumber(int n, int[] templeHeight)
        {
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int left = 0, right = 0;

                for (int j = i - 1; j >= 0; --j)
                {
                    if (templeHeight[j] < templeHeight[j + 1])
                    {
                        ++left;
                    }
                    else
                    {
                        break;
                    }
                }

                for (int j = i + 1; j < n; ++j)
                {
                    if (templeHeight[j] < templeHeight[j - 1])
                    {
                        ++left;
                    }
                    else
                    {
                        break;
                    }
                }

                sum += Math.Max(right, left) + 1;
            }

            return sum;
        }
    }
}
