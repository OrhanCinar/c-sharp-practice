using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class MaximumSumIncreasingSubsequence2
    {
        void ConstructMaxSumIS(List<int> arr, int n)
        {
            List<Tuple<int, int>> L = new List<Tuple<int, int>>();

            int index = 0;


            foreach (var i in arr)
            {
                L.Add(new Tuple<int, int>(i, index));
                index++;
            }

            L[0] = new Tuple<int, int>(L[0].Item1, -1);


            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] > arr[j] && L[i].Item1 < arr[i] + L[j].Item2)
                    {
                        L[i] = new Tuple<int, int>(arr[i] + L[j].Item1, j);
                    }
                }
            }

            int maxi = Int32.MinValue, currIndex = 0, track = 0;

            foreach (Tuple<int, int> p in L)
            {
                if (p.Item1 > maxi)
                {
                    maxi = p.Item1;
                    currIndex = track;
                }

                track++;
            }

            List<int> result = new List<int>();

            int prevoiusIndex;

            while (currIndex >= 0)
            {
                result.Add(arr[currIndex]);
                prevoiusIndex = L[currIndex].Item2;

                if (currIndex == prevoiusIndex)
                {
                    break;
                }

                currIndex = prevoiusIndex;
            }


            for (int i = result.Count; i >= 0; i--)
            {
                Console.Write(result[i] + " ");
            }

        }
    }
}
